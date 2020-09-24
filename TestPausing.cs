using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class TestPausing : MonoBehaviour
{
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        if (isPaused)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            isPaused = false;
        }
        else
        {
            EventManager.EmitEvent(GameConstants.PauseGame);
            isPaused = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
