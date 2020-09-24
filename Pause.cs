using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(GameConstants.PauseGame, PauseGame);
        EventManager.StartListening(GameConstants.UnpauseGame, UnpauseGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnpauseGame()
    {
        if (GlobalStaticVariables.isPaused)
        {
            Time.timeScale = 1f;
            GlobalStaticVariables.isPaused = false;
            Debug.Log("Game has been unpaused");
        }



    }
    void PauseGame()
    {
        if (!GlobalStaticVariables.isPaused)
        {
            Time.timeScale = 0f;
            GlobalStaticVariables.isPaused = true;
            Debug.Log("Game has been paused");
        }


    }

}
