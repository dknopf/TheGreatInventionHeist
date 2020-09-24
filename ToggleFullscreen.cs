using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleFullscreen : MonoBehaviour
{

    //Sets the fullscreen button text every time you open the settings modal
    public void Start()
    {
        SetFullscreenButtonText();
    }

    public void Toggle()
    {
        StartCoroutine(GoFullscreen());
    }

    IEnumerator GoFullscreen()
    {
        GameObject fullscreenButtonText = this.transform.GetChild(0).gameObject;
        string buttonText = "";
        if (!Screen.fullScreen)
        {
            Screen.fullScreen = true;
            buttonText = "exit fullscreen";
        }
        else
        {
            Screen.fullScreen = false;
            buttonText = "fullscreen";
        }
        //Unity waits until the end of a frame to go fullscreen so the code has to wait
        //before it checks the new fullscreen values
        yield return new WaitForEndOfFrame();
        fullscreenButtonText.GetComponent<Text>().text = buttonText;

        //This forced the canvas to update before the end of the frame
        //I think it helps to ensure that the text is properly changed
        Canvas.ForceUpdateCanvases();
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    private void SetFullscreenButtonText()
    {
        GameObject fullscreenButtonText = this.transform.GetChild(0).gameObject;
        string buttonText = "";
        if (Screen.fullScreen)
        {
            buttonText = "exit fullscreen";
        }
        else
        {
            buttonText = "fullscreen";
        }

        fullscreenButtonText.GetComponent<Text>().text = buttonText;
        Canvas.ForceUpdateCanvases();
    }
}
