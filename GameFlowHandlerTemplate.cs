using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using TigerForge;
using System;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System.Linq;
using UnityEngine.UI;

public class GameFlowHandlerTemplate : MonoBehaviour
{
    public bool ShowDebugLog;
    public float SelectedPropSpeed = 40.0f;
    public float PropMovementTolerance = 0.3f;
    public (float, float) XBoundary = (-10, 10);
    public (float, float) YBoundary = (-5, 5);
    public string whichAnimationFinished = null;
    public string properAnimationProp = null;

    private PropCollisionResponseTable CollisionResponses = new PropCollisionResponseTable();
    private HashSet<GameObject> SceneProps = new HashSet<GameObject>();
    private EventsGroup EventListenerGroup = new EventsGroup();
    private GameObject SelectedProp;
    private List<String> InitialPropList = new List<string>();
    private bool setUp;
    private GetLearnMoreText GetLearnMore = new GetLearnMoreText();

    private GetCustomUI CustomUIGetter = new GetCustomUI();
    private CreateModal modalMaker = new CreateModal();

    private bool funHad = false;


    //
    // Public functions
    //

    // checks if 2 props are valid collisions
    public bool IsValidPropCollision(GameObject prop1, GameObject prop2)
    {
        // check that both are not null
        if (prop1 == null || prop2 == null)
        {
            PrintLog("invalid collision, one or more props is null");
            return false;
        }

        // check that both are currently in the scene
        //if (!SceneProps.Contains(prop1) || !SceneProps.Contains(prop2))
        //{
        //    PrintLog("invlalid collision, props not in scene");
        //    return false;
        //}

        // passes all checks
        return true;
    }

    //
    // Event Listener setup functions
    //

    // adds event listener that calls the callback function on receiving event
    protected virtual void AddEventListener(string eventName, UnityAction callback)
    {
        EventListenerGroup.Add(eventName, callback);
    }

    protected virtual void PopulateEventListenters()
    {
        AddEventListener(GameConstants.PropCollisionEvent,          HandlePropCollision          );
        AddEventListener(GameConstants.InventoryPropClickEvent,     HandleInventoryPropMouseDown );
        AddEventListener(GameConstants.PropInventoryCollisonEvent,  HandlePropInventoryCollision );
        //AddEventListener(GameConstants.PauseGame,                   PauseGame                    );
        //AddEventListener(GameConstants.UnpauseGame,                 UnpauseGame                  );
        AddEventListener(GameConstants.PropAnimationFinishedEvent,  ReenableProps                );
        AddEventListener(GameConstants.SavingCompleteEvent,         LevelCompletionHandler       );
        AddEventListener(GameConstants.FinalPropCreationEvent,      FinalPropCreationHandler     );
        AddEventListener(GameConstants.LearnMoreClosedEvent,        HaveMoreFun                  );
        //AddEventListener(GameConstants.GameCompleteEvent,           SetSaveToGameComplete        );


    }

    // Prepares object's event listeners and starts listening
    protected virtual void StartEventListeners()
    {
        PopulateEventListenters();
        EventListenerGroup.StartListening();
    }

    //
    // event callback functions
    // override in children based on level requirements
    //


    protected virtual void HandlePropInventoryCollision()
    {
        SFXManager.PlaySound("propDrop");
        var sender = EventManager.GetGameObject(GameConstants.PropInventoryCollisonEvent);
        EventManager.SetDataGroup(GameConstants.AddToInventory, sender, IsInitial(sender));
        EventManager.EmitEvent(GameConstants.AddToInventory);
        RemovePropFromWorkBench(sender);
    }

    public bool IsInitial (GameObject sender)
    {
        Regex myRegex = new Regex(@"(?!\w*/)" + sender.name + @"\w*");

        foreach (string entry in InitialPropList)
        {
            if (myRegex.IsMatch(entry))
            {
                return true;
            }
        }
        return false;
    }

    protected virtual void HandlePropCollision()
    {
        PrintLog("detected prop collision");
        var sender = EventManager.GetSender(GameConstants.PropCollisionEvent);

        GameObject collisionProp1 = (GameObject)sender;
        GameObject collisionProp2 = EventManager.GetGameObject(GameConstants.PropCollisionEvent);

        // check for collision props are valid for collision
        if (!IsValidPropCollision(collisionProp1, collisionProp2))
        {
            return;
        }

        var (
            responseID,
            dialog,
            resultingObject,
            isLearnMore
            ) = CollisionResponses.getResponse(collisionProp1, collisionProp2);

        PrintLog("initiate response (id: " + responseID + " , dialog: " + dialog + " , object: " + resultingObject);

        switch (responseID)
        {
            case PropCollisionResponseTable.FailStateResponseID:
                handleFailStateCollision(dialog, resultingObject, collisionProp1, collisionProp2);
                break;

            case PropCollisionResponseTable.MisfireResponseID:
                handleMisfireCollision(dialog, resultingObject, collisionProp1, collisionProp2, isLearnMore);
                break;

            case PropCollisionResponseTable.PropMergeResponseID:
                handlePropMergeResponse(dialog, resultingObject, collisionProp1, collisionProp2, isLearnMore);
                break;

            default:
                PrintLog("received invalid responseID: " + responseID);
                break;

        }
    }

    protected virtual void HandleInventoryPropMouseDown()
    {
        if (!GlobalStaticVariables.isPaused)
        {
            var mousePosition = Input.mousePosition;
            var targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            var sender = EventManager.GetSender(GameConstants.InventoryPropClickEvent);
            if (sender == null) { throw new Exception("Null Sender"); }
            GameObject inventoryProp = (GameObject)sender;
            string basePath = inventoryProp.tag;
            string propName = inventoryProp.name;
            var targetProp = Resources.Load<GameObject>(basePath + '/' + propName);
            var generatedProp = AddPropToWorkBench(targetProp, targetPosition);
            Interactable propController = generatedProp.GetComponent<Interactable>();
            generatedProp.tag = inventoryProp.tag;
            generatedProp.name = inventoryProp.name;

            //Puts the prop in hand in the front of the screen
            GlobalStaticVariables.topLayer += 1;
            generatedProp.GetComponent<SpriteRenderer>().sortingOrder = GlobalStaticVariables.topLayer;

            propController.SelectObject();
            propController.SetFromInventory();
            EventManager.SetDataGroup(GameConstants.RemoveFromInventory, inventoryProp, IsInitial(inventoryProp));
            EventManager.EmitEvent(GameConstants.RemoveFromInventory);
        }
    }

    public void ReenableProps()
    {
        var sender = EventManager.GetSender(GameConstants.PropAnimationFinishedEvent);
        GameObject go = (GameObject)sender;
        whichAnimationFinished = go.name;
    }

    //waits until the animation is finished
    //PropAnimation
    IEnumerator MisfireAnimationHandler(GameObject animatedProp, GameObject prop1, GameObject prop2, string dialog, bool isLearnMore)
    {
        //Sets the inventory sorting layer to topLayer-1, one greater than scrim
        EventManager.EmitEvent(GameConstants.MisfireAnimationStarted);

        GameObject whiteScrim = CreateWhiteScrim();

        //This line activates smallBox in dialogueBoxHandler,
        //Closing the dialogue box during animations
        EventManager.EmitEvent(GameConstants.LoadInModalClosedEvent);


        //Remove combined props during misfire animation
        if(prop1 != null)
        {
            prop1.SetActive(false);
        }
        if(prop2 != null)
        {
            prop2.SetActive(false);
        }
        properAnimationProp = animatedProp.name;
        yield return new WaitUntil(() => properAnimationProp == whichAnimationFinished);
        if(prop1 != null)
        {
            prop1.SetActive(true);
        }
        if(prop2 != null)
        {
            prop2.SetActive(true);
        }

        Destroy(whiteScrim);

        SeparateProps(prop1, prop2);

        EventManager.SetDataGroup(GameConstants.DisplayDialog, dialog, "Sad", isLearnMore);
        EventManager.EmitEvent(GameConstants.DisplayDialog);
        EventManager.EmitEvent(GameConstants.MisfireAnimationEnded);

    }


    public void SeparateProps(GameObject prop1, GameObject prop2)
    {

        prop1.GetComponent<Interactable>().returnToLastPosition();
        prop2.GetComponent<Interactable>().returnToLastPosition();
        //Collider2D prop1Collider = prop1.GetComponent<Collider2D>();
        //Collider2D prop2Collider = prop2.GetComponent<Collider2D>();
        //Vector3 prop1Center = prop1Collider.bounds.center;
        //Vector3 prop2Center = prop2Collider.bounds.center;
        //float prop2Max = prop2Collider.bounds.max.x;
        //float prop2Min = prop2Collider.bounds.min.x;
        //float prop1Max = prop1Collider.bounds.max.x;
        //float prop1Min = prop1Collider.bounds.min.x;

        //if (prop1Center.x > prop2Center.x)
        //{
        //    prop1.transform.position = new Vector3(prop1.transform.position.x + (prop2Max - prop1Min) / 2, prop1.transform.position.y, prop1.transform.position.z);
        //    prop2.transform.position = new Vector3(prop2.transform.position.x - (prop2Max - prop1Min) / 2, prop2.transform.position.y, prop2.transform.position.z);

        //}
        //else
        //{
        //    prop1.transform.position = new Vector3(prop1.transform.position.x - (prop1Max - prop2Min) / 2, prop1.transform.position.y, prop1.transform.position.z);
        //    prop2.transform.position = new Vector3(prop2.transform.position.x + (prop1Max - prop2Min) / 2, prop2.transform.position.y, prop2.transform.position.z);

        //}

    }

    public Vector3 GetBiggestProp(GameObject prop1, GameObject prop2)
    {
        Collider2D prop1Collider = prop1.GetComponent<Collider2D>();
        Collider2D prop2Collider = prop2.GetComponent<Collider2D>();
        Vector3 prop1Center = prop1Collider.bounds.center;
        Vector3 prop2Center = prop2Collider.bounds.center;
        Vector3 prop2Max = prop2Collider.bounds.max;
        Vector3 prop2Min = prop2Collider.bounds.min;
        Vector3 prop1Max = prop1Collider.bounds.max;
        Vector3 prop1Min = prop1Collider.bounds.min;

        Vector3 newPosition = prop1Center;
        if (Vector3.Distance(prop2Max, prop2Min) > Vector3.Distance(prop1Max, prop1Min))
        {
            newPosition = prop2Center;
        }
        return newPosition;
    }

    public void PlayParticleEffects(GameObject prop)
    {
        if (prop.GetComponent<ParticleSystem>() != null)
        {
            ParticleSystem system = prop.GetComponent<ParticleSystem>();
            if (!system.isPlaying)
            {
                system.Play();
            }
        }

    }

    //
    // functions for handling prop collisions
    // overwrite at will
    // but these are default behaviors
    //
    protected virtual void handleFailStateCollision(string dialog, GameObject resultingObject, GameObject prop1, GameObject prop2)
    {
        EventManager.EmitEvent(GameConstants.FailedPropCollisionEvent);
        SeparateProps(prop1, prop2);
        PrintLog("failed merge reponse");
    }

    protected virtual void handleMisfireCollision(string dialog, GameObject resultingObject, GameObject prop1, GameObject prop2, bool isLearnMore)
    {
        PrintLog("misfire collision response");
        if (resultingObject != null)
        {

            //Put the new prop in the center of the screen
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2) + 100, Screen.height / 2, Camera.main.nearClipPlane));
            GameObject misfireAnimationProp = AddPropToWorkBench(resultingObject, newPosition);

            //Puts the misfire animation in the front of the screen
            //On top of all the other props
            GlobalStaticVariables.topLayer += 1;
            misfireAnimationProp.GetComponent<SpriteRenderer>().sortingOrder = GlobalStaticVariables.topLayer;

            whichAnimationFinished = null;
            StartCoroutine(MisfireAnimationHandler(resultingObject, prop1, prop2, dialog, isLearnMore));
        }
        else
        {
            EventManager.SetDataGroup(GameConstants.DisplayDialog, dialog, "Sad", isLearnMore);
            EventManager.EmitEvent(GameConstants.DisplayDialog);
            SeparateProps(prop1, prop2);
        }
        SFXManager.PlaySound("fail");
    }

    protected virtual void handlePropMergeResponse(string dialog, GameObject resultingObject, GameObject prop1, GameObject prop2, bool isLearnMore)
    {
        PrintLog("successful merge response");
        EventManager.SetData(GameConstants.SuccessfulPropCreation, resultingObject);
        EventManager.EmitEvent(GameConstants.SuccessfulPropCreation);

        EventManager.SetDataGroup(GameConstants.DisplayDialog, dialog, "Happy", isLearnMore);
        EventManager.EmitEvent(GameConstants.DisplayDialog);
        //Put the new prop wherever the bigger prop was
        GameObject newProp = AddPropToWorkBench(resultingObject, GetBiggestProp(prop1, prop2));
        RemovePropFromWorkBench(prop1);
        RemovePropFromWorkBench(prop2);
        PlayParticleEffects(newProp);
        SFXManager.PlaySound("propSuccess");

        string sceneName = SceneManager.GetActiveScene().name;
        string level = sceneName.Substring(0, sceneName.IndexOf("Workbench", 0, sceneName.Length));


    }

    protected virtual GameObject AddPropToWorkBench(GameObject obj, Vector3 position)
    {
        var newProp = Instantiate(obj, position, Quaternion.identity);
        newProp.name = newProp.name.Split('(')[0];
        AddPropToSceneProps(newProp);
        return newProp;
    }

    protected virtual void RemovePropFromWorkBench(GameObject obj)
    {
        _ = SceneProps.Remove(obj);
        Destroy(obj);
    }

    //
    // Various helper functions
    // DO NOT OVERWRITE*
    // *terms and conditions may apply
    //

    // prop movement helper functions
    protected Vector3 AdjustCoordinateToBounds(Vector3 coords, (float,float) xBounds, (float,float) yBounds)
    {
        var (minX, maxX) = xBounds;
        var (minY, maxY) = yBounds;
        return new Vector3(
            Mathf.Max(minX, Mathf.Min(maxX, coords.x)),
            Mathf.Max(minY, Mathf.Min(maxY, coords.y))
            );
    }

    protected bool WithinTolerance(Vector3 initialCoords, Vector3 targetCoords, float tolerance)
    {
        Vector3 diff = targetCoords - initialCoords;
        return diff.magnitude <= tolerance;
    }

    protected bool IsWithinBound(float x, (float,float) range)
    {
        var (min, max) = range;
        return x >= min && x <= max;
    }

    protected void PrintLog(string message)
    {
        if (ShowDebugLog)
        {
            Debug.Log(message);
        }
    }


    /*
     * MISC helper functions
     */

    private GameObject CreateWhiteScrim()
    {
        /*
        Creates a white scrim to highlight the prop displayed
        Sets the white scrims sorting layer to one above the other props but below the animated prop.
        Putting the plane distance at 101 and toplayer-2 makes it right after the inventory so the inventory
        isn't covered.
        This puts the scrim in the center of the screen
        */

        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2) + 100, Screen.height / 2, Camera.main.nearClipPlane));
        GameObject whiteScrimCanvas = Instantiate(Resources.Load<GameObject>("GlobalPrefabs/WhiteScrimCanvas"), newPosition, Quaternion.identity);
        whiteScrimCanvas.GetComponent<Canvas>().worldCamera = Camera.main;
        whiteScrimCanvas.GetComponent<Canvas>().planeDistance = 101f;
        whiteScrimCanvas.GetComponent<Canvas>().sortingOrder = GlobalStaticVariables.topLayer-2;
        return whiteScrimCanvas;
    }

    //
    // Initialization functions
    //

    private void SetLevelSpecificUI()
    {


        //Set custom color schemes
        GameObject inventory = GameObject.Find("InventoryScrollList");
        GameObject viewport = GameObject.Find("InventoryListViewport");
        GameObject dialogBoxOpen = GameObject.Find("Dialog Box");
        GameObject dialogBoxClosed = dialogBoxOpen.transform.GetChild(0).gameObject;


        GameObject UICanvas = GameObject.Find("UI Canvas");
        GameObject settingsButton = UICanvas.transform.GetChild(2).gameObject;
        GameObject exitButton = UICanvas.transform.GetChild(3).gameObject;
        GameObject tooltipCanvas = GameObject.Find("Tooltip Canvas");
        GameObject tooltipImage = tooltipCanvas.transform.GetChild(0).gameObject;
        GameObject tooltipText = tooltipImage.transform.GetChild(0).gameObject;
        GameObject progressBarTop = GameObject.Find("progressBarTop");
        GameObject progressBarBottom = GameObject.Find("Progress Bar");
        GameObject xButton = dialogBoxOpen.transform.GetChild(2).gameObject;
        GameObject learnMoreButton = dialogBoxOpen.transform.GetChild(4).gameObject;
        GameObject topScrollButton = GameObject.Find("topScrollButton");
        GameObject bottomScrollButton = GameObject.Find("bottomScrollButton");

        string sceneName = SceneManager.GetActiveScene().name;
        string level = sceneName.Substring(0, sceneName.IndexOf("Workbench", 0, sceneName.Length));
        string levelNum = level.Substring(5, 3);

        inventory.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/Inventory Boxes/" + levelNum + "InventoryBox");
        dialogBoxOpen.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/Inventor Boxes/" + levelNum + "InventorBoxOpen");
        dialogBoxClosed.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/Inventor Boxes/" + levelNum + "InventorBoxClosed");

        Dictionary<string, (string, string)> customUIDict = CustomUIGetter.getCustomUIDict(level);

        List<KeyValuePair<string, (string, string)>> UIValuesList = CustomUIGetter.getCustomUI(level);
        EventManager.SetDataGroup(GameConstants.SetCustomUI, UIValuesList);

        Color mainCol;
        Color hoverCol;
        Color tooltipTextCol;
        Color progressBarTopCol;
        Color progressBarBottomCol;
        Color xButtonCol;
        var (mainColor, hoverColor) = customUIDict["mainColor"];
        var (tooltipTextColor, nothing) = customUIDict["tooltipText"];
        var (progressBarTopColor, nothing2) = customUIDict["progressBarTop"];
        var (progressBarBottomColor, nothing3) = customUIDict["progressBarBottom"];
        var (xButtonColor, nothing4) = customUIDict["progressBarBottom"];
        ColorUtility.TryParseHtmlString(mainColor, out mainCol);
        ColorUtility.TryParseHtmlString(hoverColor, out hoverCol);
        ColorUtility.TryParseHtmlString(tooltipTextColor, out tooltipTextCol);
        ColorUtility.TryParseHtmlString(progressBarTopColor, out progressBarTopCol);
        ColorUtility.TryParseHtmlString(progressBarBottomColor, out progressBarBottomCol);
        ColorUtility.TryParseHtmlString(xButtonColor, out xButtonCol);

        settingsButton.GetComponent<Image>().color = mainCol;
        ColorBlock newColors = settingsButton.GetComponent<Button>().colors;
        newColors.highlightedColor = hoverCol;
        settingsButton.GetComponent<Button>().colors = newColors;

        exitButton.GetComponent<Image>().color = mainCol;
        newColors = exitButton.GetComponent<Button>().colors;
        newColors.highlightedColor = hoverCol;
        exitButton.GetComponent<Button>().colors = newColors;


        learnMoreButton.GetComponent<Image>().color = mainCol;
        newColors = learnMoreButton.GetComponent<Button>().colors;
        newColors.highlightedColor = hoverCol;
        learnMoreButton.GetComponent<Button>().colors = newColors;

        xButton.GetComponent<Image>().color = xButtonCol;

        tooltipImage.GetComponent<Image>().color = mainCol;
        tooltipText.GetComponent<Text>().color = tooltipTextCol;

        progressBarTop.GetComponent<Image>().color = progressBarTopCol;
        progressBarBottom.GetComponent<Image>().color = progressBarBottomCol;

        topScrollButton.GetComponent<Image>().color = xButtonCol;
        bottomScrollButton.GetComponent<Image>().color = xButtonCol;

    }

    private void FunCherries()
    {
        if (!GlobalStaticVariables.onMultiPageModalScreen)
        {
            //TeeHee
            if (Input.GetKey("left shift") && Input.GetKey("e") && !funHad)
            {
                modalMaker.CreateMultiPageModal("Level4_2", "So THIS is inside baseball!", GameConstants.InventorySpriteFolderName + "/collisionAssets/zestyUIAsset", "LearnMoreModal");
                EventManager.EmitEvent(GameConstants.PauseGame);
                funHad = true;
            }
            if (Input.GetKey("left shift") && Input.GetKey("c") && !funHad)
            {
                modalMaker.CreateMultiPageModal("Level4_3", "So, the time is come for me to make my commitment. I have committed myself, I have dedicated myself to the pursuit of the Dragon. And having made that commitment, having decided that once and for all, now, all of a sudden, I can see him. There he is, right in front of me! As clear as day. I never thought that I would see you this clearly. I always saw you in brief glimpses in the dark. But now, now… You’re so much bigger than I ever imagined! And… I’m not so sure I like this. I mean, yes, you’re glorious and beautiful… But you’re ugly too! Your breath reeks of death! No… I… I never had any childish fantasy either, about conquering you, but that thinking is for children. You are beyond that, indeed, I can see, stretched around your feet, the bodies of my predecessors! And all you have to show for it is a few nicks and scratches. But do you have to laugh at me that way?! Am I so pitiful that you can sneer in my face like that?! Yes! Yes, you frighten me! You hurt me! I’ve felt your claws ripping through my soul! But I’m going to die someday! And before I can do that, I got to face you, eyeball to eyeball! I’ve got to look you right in the eye and see what’s inside! But I’m not good enough to do that yet! I’m not experienced enough! So I’m going to have to start learning. Today. Here. Now. Come, Dragon! I will fight you! Sancho Panza, my sword! For truth! For beauty! For Art! CHARGE!!!", GameConstants.InventorySpriteFolderName + "/collisionAssets/url", "LearnMoreModal");
                EventManager.EmitEvent(GameConstants.PauseGame);
                funHad = true;
            }
            if (Input.GetKey("left shift") && Input.GetKey("t") && !funHad)
            {
                modalMaker.CreateMultiPageModal("Level5_1", "While the global situations surrounding the creation of this game were less than fortunate... And the Weaver situation surrounding everrything else was even less fortunate... Our team stepped up and worked together to create this incredible game, right at the intersection of art and technology. No other group could have made such a grueling process something enjoyable, nor made standup zoom meetings a weekly highlight. So, after thousands of Slack messages, dozens of unecessary lectures, hours and hours and hours of hard work, and SO much good banter, team Mystery Machine is so happy to lovingly present, The Great Invention Heist. Even though it should have been named Reinventing the Wheel.", GameConstants.InventorySpriteFolderName + "/collisionAssets/teamPhoto", "LearnMoreModal");
                EventManager.EmitEvent(GameConstants.PauseGame);
                funHad = true;
            }
            if (Input.GetKey("left shift") && Input.GetKey("g") && !funHad)
            {
                EventManager.EmitEvent(GameConstants.GameCompleteEvent);
            }


        }
    }

    private void HaveMoreFun()
    {
        funHad = false;
    }

    //Was trying to test game complete modal
    //public void SetSaveToGameComplete()
    //{
    //    Debug.Log("got to top of set save to game complete");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level0_0");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level1_1");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level1_2");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level1_3");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level2_1");
    //    EventManager.EmitEvent(GameConstants.LevelCompleteEvent, "Level2_2");
    //}
    public void AddPropToSceneProps(GameObject obj)
    {
        SceneProps.Add(obj);
    }

    protected void InitializeSceneProps()
    {

    }

    protected void SetResponseTable(PropCollisionResponseTable newTable)
    {
        CollisionResponses = newTable;
    }

    protected virtual void InitializeResponseTable()
    {

    }

    protected virtual void PopulateInventory()
    {
        GameObject[] propList = new GameObject[InitialPropList.Count];
        for(int i = 0; i < InitialPropList.Count; i++)
        {
            string path = InitialPropList[i];
            propList[i] = Resources.Load<GameObject>(path);
        }
        EventManager.SetData(GameConstants.InitializeInventoryEvent, propList);
        EventManager.EmitEvent(GameConstants.InitializeInventoryEvent);
    }

    protected void SetInitialInventoryPropList(List<String> propsList)
    {
        InitialPropList = propsList;
    }

    protected virtual void LevelInitialization()
    {
        EventManager.EmitEvent(GameConstants.UnpauseGame);
    }

    protected virtual void PostLoadSetUp()
    {
        StartEventListeners();
        InitializeResponseTable();
        SetLevelSpecificUI();
        PopulateInventory();
    }

    // Level Completion function

    protected virtual void LevelCompletionHandler()
    {

        EventManager.SetData(GameConstants.LoadLevelEvent, GameConstants.MapSceneName);
        EventManager.EmitEvent(GameConstants.LoadLevelEvent);
    }

    protected virtual void FinalPropCreationHandler()
    {
        EventManager.EmitEvent(GameConstants.ClearInventoryEvent);
        EventManager.EmitEvent(GameConstants.RemoveAllPropEvent);
    }

    // Start is called before the first frame update
    void Start()
    {
        LevelInitialization();
        setUp = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!setUp)
        {
            PostLoadSetUp();
            setUp = true;
        }

        FunCherries();
    }


}
