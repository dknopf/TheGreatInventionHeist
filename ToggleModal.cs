using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToggleModal : MonoBehaviour
{
    public GameObject Modal;
    public void ToggleTheModal()
    {
        if (GlobalStaticVariables.isPaused)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            //Debug.Log("settins unpaused");


        }
        else
        {
            EventManager.EmitEvent(GameConstants.PauseGame);
            //Debug.Log("settins paused");

        }
        switch (Modal.name)
        {
            case "LearnMoreModal(Clone)":

                EventManager.EmitEvent(GameConstants.LearnMoreClosedEvent);
                Destroy(Modal);
                break;
            case "LoadInModal(Clone)":
                if (GlobalStaticVariables.isPaused)
                {
                    EventManager.EmitEvent(GameConstants.UnpauseGame);
                }
                if (SceneManager.GetActiveScene().name == "Level0_0Workbench")
                {
                    EventManager.SetDataGroup(GameConstants.DisplayDialog, DialogueConstants.Level0_0.exitLoadInModal, "Happy", false);
                    EventManager.EmitEvent(GameConstants.DisplayDialog);
                }
                else
                {
                    EventManager.EmitEvent(GameConstants.LoadInModalClosedEvent);
                }
                Destroy(Modal);
                break;

            case "SettingsMenu":
                GameObject fullScreenButton = Modal.transform.GetChild(7).gameObject;
                string buttonText = "";
                switch (Screen.fullScreen)
                {
                    case true:
                        buttonText = "exit fullscreen";
                        break;
                    case false:
                        buttonText = "fullscreen";
                        break;
                }
                GameObject fullscreenButtonText = fullScreenButton.transform.GetChild(0).gameObject;
                fullscreenButtonText.GetComponent<Text>().text = buttonText;
                Modal.SetActive(!Modal.activeSelf);
                break;

            case "titleCardCanvas":
                EventManager.EmitEvent(GameConstants.TitleCardClosed);
                Modal.SetActive(!Modal.activeSelf);
                //Set it to false so it will be set true at the end of the function
                //It sucks, I know.
                GlobalStaticVariables.onMultiPageModalScreen = false;
                break;


            default:
                Modal.SetActive(!Modal.activeSelf);
                break;
        }
        GlobalStaticVariables.onMultiPageModalScreen = !GlobalStaticVariables.onMultiPageModalScreen;
    }
}
