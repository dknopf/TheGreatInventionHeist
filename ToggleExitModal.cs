using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class ToggleExitModal : MonoBehaviour
{
    public GameObject exitModalReference;
    // Start is called before the first frame update

    public void ToggleModal()
    {
        if (GlobalStaticVariables.isPaused)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);

        }
        else
        {
            EventManager.EmitEvent(GameConstants.PauseGame);

        }
        GameObject exitModal = GameObject.Find("exitModal");
        if (exitModal == null)
        {
            exitModalReference.SetActive(!exitModalReference.activeSelf);
        }
        else
        {
            exitModal.SetActive(!exitModal.activeSelf);

        }
    }
}
