using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.UI;

public class CanvasChangePageHandler : MonoBehaviour
{
    //Handles changing the text in the modals
    //NEEDS TO HAVE NEXT AND PREV BUTTONS DRAGGED IN THE INSPECTOR

    public Dictionary<int, string> pageDict;
    public int pageNum = 0;
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject exitButton = null;
    public bool isGameCompleteModal = false;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("CanvasChangePageHandler started");
        EventManager.StartListening(GameConstants.ChangeModalPageClickedEvent, ChangeModalPage);
    }

    public void ChangeModalPage()
    {
        GameObject sender = EventManager.GetGameObject(GameConstants.ChangeModalPageClickedEvent);

        Debug.Log("pageNum in canvasChangePageHandler is" + pageNum);
        switch (sender.name)
        {
            case "nextButton":
                if (pageNum + 1 >= pageDict.Count) 
                {
                    //Do nothing if its the last panel
                    break;
                } 
                else if (pageNum + 2 >= pageDict.Count)
                {
                    sender.SetActive(false);
                    if (exitButton != null)
                    {
                        exitButton.SetActive(true);
                    }

                    //For the game complete modal to change images
                }
                prevButton.SetActive(true);
                pageNum++;
                break;
            case "prevButton":
                if (pageNum == 0)
                {
                    break;
                }
                if (pageNum - 1 <= 0)
                {
                    sender.SetActive(false);
                }
                if (exitButton != null)
                {
                    exitButton.SetActive(false);
                }
                nextButton.SetActive(true);
                pageNum--;
                break;
        }

        //Set the text
        GameObject modalText = GameObject.Find("modalText");
        modalText.GetComponent<Text>().text = pageDict[pageNum];


        //Very temp code for changing the images in a multipage modals
        Debug.Log("pageNum in cancasChangePageHandler above changing the image is " + pageNum);
        if (isGameCompleteModal)
        {
            GameObject modalCanvas = sender.transform.parent.gameObject;
            GameObject displayImage = modalCanvas.transform.GetChild(2).gameObject;
            pageNum++;
            Debug.Log("got into isGameCompleteModal if statement to change image");
            displayImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Map Mode/UI Assets/gameCompleteImages/gameCompleteImage" + pageNum);
            pageNum--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
