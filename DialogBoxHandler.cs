using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;
using UnityEngine.SceneManagement;

public class DialogBoxHandler : MonoBehaviour
{
    public Text dialogBox;
    Image invBox;
    public Button exitButton;
    public Button learnMoreButton;
    public Button smallBoxButton;
    public Image inventor;
    public Image inventor2;
    Sprite inventorSprite;
    private bool learnMoreBtn;
    private string level;
    private string levelNum;

    private string learnMoreText;
    private string pathToImage;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        EventManager.StartListening(GameConstants.FinalPropCompleteEvent, destroyBox);
        EventManager.StartListening(GameConstants.LearnMoreInteractionEvent, SetLearnMoreButton);
        //EventManager.StartListening(GameConstants.LearnMoreInteractionEvent, learnMoreBox);
        EventManager.StartListening(GameConstants.LearnMoreClosedEvent, fullLearnMoreBox);
        EventManager.StartListening(GameConstants.LoadInModalClosedEvent, smallBox);
        EventManager.StartListening(GameConstants.DisplayDialog, fullBox2);
        //EventManager.StartListening(GameConstants.DisplayDialog, fullBox);
        EventManager.StartListening(GameConstants.FailedPropCollisionEvent, smallBox);
        EventManager.StartListening(GameConstants.TriggerDialogBoxVisualCue, DialogBoxVisualCue);
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(smallBox);
        learnMoreButton.onClick.AddListener(noBox);
        smallBoxButton.onClick.AddListener(openClosedBox);
        string sceneName = SceneManager.GetActiveScene().name;
        level = sceneName.Substring(0, sceneName.IndexOf("Workbench", 0, sceneName.Length));
        levelNum = level.Substring(5,3);
        inventorSprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorHappy");
        inventor.sprite = inventorSprite;
        inventor2.sprite = inventorSprite;
        smallBoxButton.interactable = false;
        learnMoreBtn = false;
        noBox();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void openClosedBox()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.DisplayDialog);
        string dialog = eventData[0].ToString();
        bool isLearnMore = eventData[2].ToBool();

        GameObject child;
        for(int i=1; i< 4; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(true);
        }

        child = this.transform.GetChild(0).gameObject;
        child.SetActive(false);

        if(isLearnMore)
        {
            child = this.transform.GetChild(4).gameObject;
            child.SetActive(true);
        }

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 1f;
        invBox.color = tempColor;

        dialogBox.text = dialog;
    }



    private void fullBox()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.DisplayDialog);

        string emote = eventData[1].ToString();
        string dialog = eventData[0].ToString();

        switch(emote)
        {
            case "Happy":
                inventorSprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorHappy");
                break;
            case "Sad":
                inventorSprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorSad");
                break;
            case null:
                break;
        }
        inventor.sprite = inventorSprite;
        inventor2.sprite = inventorSprite;


        learnMoreBtn = false;
        smallBoxButton.interactable = true;

        GameObject child;
        for(int i=1; i< 4; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(true);
        }

        child = this.transform.GetChild(0).gameObject;
        child.SetActive(false);

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 1f;
        invBox.color = tempColor;

        dialogBox.text = dialog;
    } 
    private void fullBox2()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.DisplayDialog);

        string emote = eventData[1].ToString();
        string dialog = eventData[0].ToString();
        bool isLearnMore = eventData[2].ToBool();

        switch(emote)
        {
            case "Happy":
                inventorSprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorHappy");
                break;
            case "Sad":
                inventorSprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorSad");
                break;
            case null:
                break;
        }
        inventor.sprite = inventorSprite;
        inventor2.sprite = inventorSprite;

        if (isLearnMore)
        {
            RectTransform textRT = dialogBox.GetComponent<RectTransform>();
            Vector2 pos = textRT.anchoredPosition;
            Vector2 size = textRT.sizeDelta;

            pos.y = 14.299f;
            size.y = 59f;

            textRT.anchoredPosition = pos;
            textRT.sizeDelta = size;

            learnMoreBtn = true;

            learnMoreButton.gameObject.SetActive(true);
            var onClickScript = learnMoreButton.GetComponent<LearnMoreButtonClicked>();
            onClickScript.level = level;
            onClickScript.learnMoreText = learnMoreText;
            onClickScript.pathToImage = pathToImage;
            StartCoroutine(ScalingVisualCue(this.transform.localScale, new Vector3(1.10f, 1.10f, 1.0f), 0.35f, gameObject));
        }
        else
        {
            learnMoreBtn = false;
            GameObject learnMoreButton = this.transform.GetChild(4).gameObject;
            learnMoreButton.SetActive(false);
            //Trigger visual cue for all dialog in 0_0
            if (level == "Level0_0")
            {
                StartCoroutine(ScalingVisualCue(this.transform.localScale, new Vector3(1.10f, 1.10f, 1.0f), 0.35f, gameObject));
            }
        }

        smallBoxButton.interactable = true;

        GameObject child;
        for(int i=1; i< 4; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(true);
        }

        child = this.transform.GetChild(0).gameObject;
        child.SetActive(false);

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 1f;
        invBox.color = tempColor;

        dialogBox.text = dialog;
    }

    private void fullLearnMoreBox()
    {

        smallBoxButton.interactable = true;

        GameObject child;
        for(int i=1; i< 5; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(true);
        }

        child = this.transform.GetChild(0).gameObject;
        child.SetActive(false);

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 1f;
        invBox.color = tempColor;

    }

    private void SetLearnMoreButton()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.LearnMoreInteractionEvent);

        string level = eventData[0].ToString();


        if (!string.IsNullOrEmpty(level))
        {
            learnMoreBtn = true;
            learnMoreText = eventData[1].ToString();
            pathToImage = eventData[2].ToString();
        }
    }

    private void learnMoreBox()
    {


        var eventData = EventManager.GetDataGroup(GameConstants.LearnMoreInteractionEvent);

        string level = eventData[0].ToString();

        if(string.IsNullOrEmpty(level))
        {
            learnMoreButton.gameObject.SetActive(false);
        }
        else
        {
            learnMoreBtn = true;

            RectTransform textRT = dialogBox.GetComponent<RectTransform>();
            Vector2 pos = textRT.anchoredPosition;
            Vector2 size = textRT.sizeDelta;

            pos.y = 14.299f;
            size.y = 59f;

            textRT.anchoredPosition = pos;
            textRT.sizeDelta = size;

            learnMoreButton.gameObject.SetActive(true);
            var onClickScript = learnMoreButton.GetComponent<LearnMoreButtonClicked>();
            onClickScript.level = eventData[0].ToString();
            onClickScript.learnMoreText = eventData[1].ToString();
            onClickScript.pathToImage = eventData[2].ToString();
            StartCoroutine(ScalingVisualCue(this.transform.localScale, new Vector3(1.10f, 1.10f, 1.0f), 0.35f, gameObject));

        }
    }

    private void smallBox()
    {
        GameObject child;
        for(int i=1; i< 5; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(false);
        }

        child = this.transform.GetChild(0).gameObject;
        child.SetActive(true);

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 0f;
        invBox.color = tempColor;
    }

    private void noBox()
    {
        GameObject child;
        for(int i=0; i< 5; i++)
        {
            child = this.transform.GetChild(i).gameObject;
            child.SetActive(false);
        }

        invBox = GetComponent<Image>();
        var tempColor = invBox.color;
        tempColor.a = 0f;
        invBox.color = tempColor;
    }
    private void destroyBox()
    {
        Destroy(gameObject);
    }

    IEnumerator ScalingVisualCue(Vector3 initialScale, Vector3 finalScale, float duration, GameObject dialogueBox)
    {
        //Scale up
        for (float t = 0f; t < duration/2; t += Time.deltaTime)
        {
            float normalizedTime = t / duration;
            dialogueBox.transform.localScale = Vector3.Lerp(initialScale, finalScale, normalizedTime);
            yield return null;
        }
        //Scale down
        for (float t = 0f; t < duration/2; t += Time.deltaTime)
        {
            float normalizedTime = t / duration;
            dialogueBox.transform.localScale = Vector3.Lerp(this.transform.localScale, initialScale, normalizedTime);
            yield return null;
        }

        dialogueBox.transform.localScale = initialScale; //without this, the value will end at something like 0.9992367
    }

    private void DialogBoxVisualCue()
    {
        StartCoroutine(ScalingVisualCue(this.transform.localScale, new Vector3(1.10f, 1.10f, 1.0f), 0.35f, gameObject));
    }
}
