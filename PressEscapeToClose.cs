using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class PressEscapeToClose : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenu();

        }
    }

    public void CloseMenu()
    {
        if (GlobalStaticVariables.isPaused)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            Debug.Log("Unpause by ESCing in press escape to close");

        }
        else
        {
            EventManager.EmitEvent(GameConstants.PauseGame);
            Debug.Log("Pause by ESCing in press escape to close");


        }
        switch (this.name)
        {
            case "LearnMoreModal(Clone)":
                EventManager.EmitEvent(GameConstants.LearnMoreClosedEvent);
                Destroy(gameObject);
                break;
            case "LoadInModal(Clone)":
                EventManager.EmitEvent(GameConstants.LoadInModalClosedEvent);
                Destroy(gameObject);
                break;
            case "ExitModal":
                gameObject.SetActive(!gameObject.activeSelf);
                break;
            case "StartScreen":
                Debug.Log("Closing application in pressESCToClose");
                Application.Quit();
                break;
            default:
                gameObject.SetActive(false);
                break;
        }
        GlobalStaticVariables.onMultiPageModalScreen = !GlobalStaticVariables.onMultiPageModalScreen;

    }
}
