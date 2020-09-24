using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComicGameflowHandler : MonoBehaviour
{
    public GetComicText comicText = new GetComicText();
    public string level;
    public string levelNum;
    // Start is called before the first frame update
    void Start()
    {
        LevelInitialization();
        EventManager.EmitEvent(GameConstants.UnpauseGame);
    }

    void LevelInitialization()
    {
        StartListeners();
    }
    void StartListeners()
    {
        EventManager.StartListening(GameConstants.ChangePageClickedEvent, HandleChangePageEvent);
        EventManager.StartListening(GameConstants.TitleCardClosed, SetUpComicMode);
    }
    void SetUpComicMode()
    {
        SetLevel();
        LoadFirstPanel();
    }
    void LoadFirstPanel()
    {
        Debug.Log("Got to load first panel in comic mode gameflow handler");
        var (inventorSprite, newText) = comicText.getComicText(level, 1);
        ChangePage(level + GameConstants.ComicFramePath + levelNum + "comic" + System.Convert.ToString(1), newText, GameConstants.FirstPageStatus, level + "/Sprites/" + levelNum + inventorSprite);
        SetInventor(level);    
    }

    void SetLevel()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        level = sceneName.Substring(0, sceneName.IndexOf("Comic", 0, sceneName.Length));
        levelNum = level.Substring(5);
    }

    void SetInventor(string level)
    {
        EventManager.SetData(GameConstants.SetInventorEvent, level);
        EventManager.EmitEvent(GameConstants.SetInventorEvent);
    }


    public void HandleChangePageEvent()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.ChangePageClickedEvent);
        int imageNum = eventData[0].ToInt();
        GameObject sender = eventData[1].ToGameObject();
        
        switch (sender.name)
        {
            case "nextButton":
                NextPage(imageNum);
                break;
            case "prevButton":
                //If its the first page don't let the arrow keys try and go back
                if (imageNum == 1)
                {
                    break;
                }
                PrevPage(imageNum);
                break;
        }
    }

    // If the next page is the final page, execute FinalPage, otherwise normal
    public  void NextPage(int imageNum)
    {
        //Loads the next two images and the next text, and checks if the next next image exists
        string newImagePath = level + GameConstants.ComicFramePath + levelNum + "comic" + System.Convert.ToString(imageNum + 1);
        string newText;
        string inventorSprite;
        try
        {
            (inventorSprite, newText) = comicText.getComicText(level, imageNum + 1);
        }
        catch (KeyNotFoundException)
        {
            (inventorSprite, newText) = comicText.getComicText(level, imageNum);

        }

        Sprite nextImage = Resources.Load<Sprite>(newImagePath);
        switch (nextImage)
        {
            case null:
                ChangePage(newImagePath, newText, GameConstants.LastPageStatus, inventorSprite);
                break;
            default:
                ChangePage(newImagePath, newText, GameConstants.MiddlePageStatus, inventorSprite);
                break;
        }
    }

    // If the previous page is the first page, execute FirstPage, otherwise normal
    public void PrevPage(int imageNum)
    {
        string newImagePath = level + GameConstants.ComicFramePath + levelNum + "comic" + System.Convert.ToString(imageNum - 1);
        var (inventorSprite, newText) = comicText.getComicText(level, imageNum - 1);
        Sprite prevPrevImage = Resources.Load<Sprite>(level + GameConstants.ComicFramePath + levelNum + "comic" + System.Convert.ToString(imageNum - 2));
        switch (prevPrevImage)
        {
            case null:
                ChangePage(newImagePath, newText, GameConstants.FirstPageStatus,inventorSprite);
                break;
            default:
                ChangePage(newImagePath, newText, GameConstants.MiddlePageStatus,inventorSprite);
                break;
        }
    }


    //Should change this to something like "noLeft" or "noRight" to consolidate into one piece of code
    public void ChangePage(string newImagePath, string newText, string pageStatus, string inventorSprite)
    {
        EventManager.SetDataGroup(GameConstants.ChangePageEvent, newImagePath, newText, pageStatus, level + "/Sprites/" + levelNum + inventorSprite);
        EventManager.EmitEvent(GameConstants.ChangePageEvent);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
