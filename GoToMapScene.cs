using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class GoToMapScene : MonoBehaviour
{
    public void loadMapScene()
    {
        EventManager.SetData(GameConstants.LoadLevelEvent, GameConstants.MapSceneName);
        EventManager.EmitEvent(GameConstants.LoadLevelEvent);
    }

    public void loadLevel0_0()
    {
        EventManager.SetData(GameConstants.LoadLevelEvent, "Level0_0ComicMode");
        EventManager.EmitEvent(GameConstants.LoadLevelEvent);
    }

    public void quitApplication()
    {
        Application.Quit();
    }
}
