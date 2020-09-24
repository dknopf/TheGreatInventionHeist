using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.UI;

public class ChangePageButton : MonoBehaviour
{
    public GameObject prevOrNext;
    bool isComicModeFrozen = true;

    // Start is called before the first frame update
    void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        //onMultiPageScreen = false;
        //EventManager.StartListening(GameConstants.OnMultiPageScreenCheck, HandleOnMultiPageScreenCheck);
        EventManager.StartListening(GameConstants.TitleCardClosed, UnfreezeArrowKeys);
        prevOrNext = gameObject;
    }

    void UnfreezeArrowKeys()
    {
        isComicModeFrozen = false;
    }
    //private void HandleOnMultiPageScreenCheck()
    //{
    //    bool onScreenNow = EventManager.GetBool(GameConstants.OnMultiPageScreenCheck);
    //    Debug.Log(onScreenNow);
    //    onMultiPageScreen = onScreenNow;
    //}

    public void ComicChangePageButtonClicked()
    {
        if (!isComicModeFrozen)
        {
            //Gets 1_1comic2 and turns it into 2
            string imageName = GameObject.Find("comicImage").GetComponent<Image>().sprite.name;
            Debug.Log(imageName.Substring(8));
            int imageNum = System.Convert.ToInt32(imageName.Substring(8));
            //int imageNum = System.Convert.ToInt32(imageName.Substring(imageName.IndexOf("c", 2, imageName.Length)));
            EventManager.SetDataGroup(GameConstants.ChangePageClickedEvent, imageNum, prevOrNext);
            EventManager.EmitEvent(GameConstants.ChangePageClickedEvent);
        }
    }

    public void ModalChangePageButtonClicked()
    {
        EventManager.SetData(GameConstants.ChangeModalPageClickedEvent, prevOrNext);
        EventManager.EmitEvent(GameConstants.ChangeModalPageClickedEvent);
    }

    private void Update()
    {
        //if (this.name != "nextButton" & this.name != "prevButton" & onMultiPageScreen & GlobalStaticVariables.onMultiPageModalScreen)
        if (this.name != "nextButton" & this.name != "prevButton" & GlobalStaticVariables.onMultiPageModalScreen)
        {
            NavigateWithArrowKeys();
        }
    }

    private void CallFunction()
    {
        switch (this.name)
        {
            case "comicCanvas":
                ComicChangePageButtonClicked();
                break;
            default:
                ModalChangePageButtonClicked();
                break;
        }
    }
    private void NavigateWithArrowKeys()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            prevOrNext = this.transform.GetChild(5).gameObject;
            CallFunction();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            prevOrNext = this.transform.GetChild(6).gameObject;
            CallFunction();
        }
    }
}
