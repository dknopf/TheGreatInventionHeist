using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class PauseHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(GameConstants.PauseGame, handlePause);
        EventManager.StartListening(GameConstants.UnpauseGame, handleUnpause);
    }

    public void handlePause()
    {
        GlobalStaticVariables.isPaused = true;
        Debug.Log("game paused");
    }

    public void handleUnpause()
    {
        GlobalStaticVariables.isPaused = false;
        Debug.Log("game unpaused");

        //throw new System.Exception("unpause");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
