using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.UI;

public class ComicModeUIHandler : MonoBehaviour
{

    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject continueCanvas;

    bool isComicModeFrozen = true;
    // Start is called before the first frame update
    void Awake()
    {
        StartListeners();
    }


    public void StartListeners()
    {
        EventManager.StartListening(GameConstants.ChangePageEvent, HandleChangePageEvent);
        EventManager.StartListening(GameConstants.SetInventorEvent, HandleSetInventorEvent);
        EventManager.StartListening(GameConstants.TitleCardClosed, UnfreezeComicMode);

    }
    public void UnfreezeComicMode()
    {
        isComicModeFrozen = false;
    }
    public void HandleChangePageEvent()
    {
        if (!isComicModeFrozen)
        {
            Debug.Log("Made it into the top of handle change page event in comic UI handler");

            var eventData = EventManager.GetDataGroup(GameConstants.ChangePageEvent);

            //Sets the image
            string newImagePath = eventData[0].ToString();
            Debug.Log("New Image Path in Comic Mode UI Handler is" + newImagePath);
            GameObject comicImage = GameObject.Find("comicImage");
            comicImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(newImagePath);

            if(string.Equals(newImagePath, "Level0_0/comicmode/0_0comic3"))
            {
                SFXManager.PlaySound("clothSound");
            }
            if(string.Equals(newImagePath, "Level0_0/comicmode/0_0comic4"))
            {
                SFXManager.PlaySound("poweringUp");
            }
            if(string.Equals(newImagePath, "Level0_0/comicmode/0_0comic5"))
            {
                SFXManager.PlaySound("explosion");
            }

            //Sets the text
            string newComicText = eventData[1].ToString();
            GameObject comicText = GameObject.Find("comicText");

            //Sets the inventor
            string inventorSprite = eventData[3].ToString();
            Debug.Log("inventorSprite in HandleChangePageEvent in comuc mode UI is" + inventorSprite);
            GameObject inventorImage = GameObject.Find("inventorImage");
            inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(inventorSprite);



            string comicStatus = eventData[2].ToString();
            switch (comicStatus)
            {

                case GameConstants.FirstPageStatus:
                    prevButton.SetActive(false);
                    break;
                case GameConstants.LastPageStatus:
                    nextButton.SetActive(false);
                    continueCanvas.SetActive(true);
                    GlobalStaticVariables.onMultiPageModalScreen = !GlobalStaticVariables.onMultiPageModalScreen;
                    newComicText = comicText.GetComponent<Text>().text;
                    SFXManager.PlaySound("theFlash");
                    break;
                default:
                    nextButton.SetActive(true);
                    prevButton.SetActive(true);
                    break;
            }

            comicText.GetComponent<Text>().text = newComicText;
        }
    }

    public void HandleSetInventorEvent()
    {
        string level = EventManager.GetString(GameConstants.SetInventorEvent);
        string levelNum = level.Substring(5, 3);
        //Debug.Log("levelNum in handleSetInventorEvent in comic UI handler is" + levelNum);
        GameObject inventorImage = GameObject.Find("inventorImage");
        inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(level + GameConstants.SpriteFolderPath + levelNum + "InventorHappy");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
