using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class LevelCompleteModalButton : MonoBehaviour
{

    public string levelCompleted;
    public bool isGameCompleteModal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextButtonClicked()
    {
        if (!isGameCompleteModal)
        {
            EventManager.SetData(GameConstants.LevelCompleteEvent, levelCompleted);
            EventManager.EmitEvent(GameConstants.LevelCompleteEvent);
        }
        else
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            Destroy(this.transform.parent.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
