using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject settingsMenu;

    private void Start()
    {
        //settingsMenu = GameObject.Find("settingsMenu");
    }

    public void ToggleSettingsMenu()
    {
        if (GlobalStaticVariables.isPaused)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            Debug.Log("settings unpaused");


        }
        else
        {
            EventManager.EmitEvent(GameConstants.PauseGame);
            Debug.Log("settings paused");

        }
        settingsMenu.SetActive(!settingsMenu.activeSelf);
        GameObject fullScreenButton = settingsMenu.transform.GetChild(7).gameObject;
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

    }
}
