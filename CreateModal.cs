using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;
using System.Text.RegularExpressions;

public class CreateModal
{
    private GetLevelCompleteText getText = new GetLevelCompleteText();

    //A modal which has a gray scrim, text split across multiple pages, and arrow buttons
    public void CreateMultiPageModal(string level, string textToDisplay, string pathToImage, string prefabName)
    {
        string levelNum = level.Substring(5, 3);
        Canvas multiPageModal = Object.Instantiate(Resources.Load<Canvas>("GlobalPrefabs/" + prefabName));

        GameObject inventorImage = multiPageModal.transform.GetChild(3).gameObject; 
        switch (level)
        {
            case "Level4_2":
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/collisionAssets/wonderfulSprite");
                break;
            case "Level4_3":
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/collisionAssets/zipZapZopSprite");
                break;
            case "Level5_1":
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(GameConstants.InventorySpriteFolderName + "/collisionAssets/zoeInventor");
                break;
            //For game complete modal
            case "Level0_1":
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Level0_0/Sprites/0_0InventorHappy");
                break;
            default:
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorHappy");
                break;
        }


        int charsToDisplay = 0;

        GameObject exitButton = null;

        switch (prefabName)
        {
            case "LoadInModal":
                inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorSad");

                exitButton = GameObject.Find("exitButton");

                charsToDisplay = 100;
                break;
            case "LearnMoreModal":
                //Special image of Thomas Edison with a candle
                if (level == "Level2_1")
                {
                    inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorCandle");
                }

                GameObject diagramImage = GameObject.Find("diagramImage");
                diagramImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(pathToImage);

                charsToDisplay = 170;
                break;
            case "LevelCompleteModal":
                //Special image of Thomas Edison with lightbulb
                if (level == "Level2_1")
                {
                    inventorImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(level + "/Sprites/" + levelNum + "InventorLightbulb");
                }

                //For game complete modal
                if (level == "Level0_1")
                {
                    multiPageModal.GetComponent<CanvasChangePageHandler>().isGameCompleteModal = true;

                    GameObject playAgainButton = multiPageModal.transform.GetChild(7).gameObject;
                    playAgainButton.GetComponent<LevelCompleteModalButton>().isGameCompleteModal = true;

                    GameObject playAgainButtonText = playAgainButton.transform.GetChild(0).gameObject;
                    playAgainButtonText.GetComponent<Text>().text = "complete";

                }

                exitButton = multiPageModal.transform.GetChild(7).gameObject;

                GameObject realPhoto = multiPageModal.transform.GetChild(2).gameObject;
                realPhoto.GetComponent<Image>().sprite = Resources.Load<Sprite>(pathToImage);

                LevelCompleteModalButton button = multiPageModal.transform.GetChild(7).gameObject.GetComponent<LevelCompleteModalButton>();
                button.levelCompleted = level;

                charsToDisplay = 100;
                break;
            default:
                break;
        }

        //Code for all modals
        multiPageModal.GetComponent<CanvasChangePageHandler>().exitButton = exitButton;
        if (exitButton != null)
        {
            exitButton.SetActive(false);
        }

        //Set the page dictionary
        Dictionary<int, string> pagesDict = CreatePageDict(textToDisplay, charsToDisplay);

        GameObject modalText;
        if (level == "Level0_1")
        {
            modalText = multiPageModal.transform.GetChild(4).gameObject;
        }
        else
        {
            modalText = GameObject.Find("modalText");

        }
        //Sets current page equal to the first page of the dict
        Debug.Log("pagesDict[0] in CreateModal is" + pagesDict[0]);
        modalText.GetComponent<Text>().text = pagesDict[0];


        multiPageModal.GetComponent<CanvasChangePageHandler>().pageDict = pagesDict;
        //Set prev button false
        multiPageModal.transform.GetChild(6).gameObject.SetActive(false);
        if (pagesDict.Count == 1)
        {
            if (exitButton != null)
            {
                exitButton.SetActive(true);
            }
            multiPageModal.transform.GetChild(5).gameObject.SetActive(false);

        }
        Debug.Log("got past setting prev button to false in CreateMultiPageModal");

        //Sets the onMultiPageModalScreen value to true
        GlobalStaticVariables.onMultiPageModalScreen = true;
    }

    public Dictionary<int, string> CreatePageDict (string textToSeparate, int charsToDisplay)
    {
        //Separates string into sentences, then adds sentences together until they get too big
        //And adds that string to a dict entry, increases page number and resets the currstring
        string[] sentencesArray = Regex.Split(textToSeparate, @"(?<=[.!?]\s)");
        Dictionary<int, string> pageDict = new Dictionary<int, string>();
        int pageNum = 0;
        int i = 0;
        int currLength = 0;
        string currString = "";
        while (i < sentencesArray.Length)
        {
            if (currLength + sentencesArray[i].Length < charsToDisplay)
            {
                currLength += sentencesArray[i].Length;
                currString += sentencesArray[i];
            }
            else
            {
                pageDict.Add(pageNum, currString);
                pageNum++;
                currLength = sentencesArray[i].Length;
                currString = sentencesArray[i];

            }
            i++;
        }
        pageDict.Add(pageNum, currString);
        return pageDict;
    }
}
