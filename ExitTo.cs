using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.SceneManagement;

public class ExitTo : MonoBehaviour
{
    // Start is called before the first frame update

    public void ExitToMainMenu()
    {
        EventManager.SetData(GameConstants.LoadLevelEvent, GameConstants.MainMenuSceneName);
        EventManager.EmitEvent(GameConstants.LoadLevelEvent);
    }
    public void ExitToMapMode()
    {
        EventManager.SetData(GameConstants.LoadLevelEvent, GameConstants.MapSceneName);
        EventManager.EmitEvent(GameConstants.LoadLevelEvent);
    }

    public void ExitToComicMode()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        Debug.Log("currentSceneName in ExitToComicMode in ExitTo is " + currentSceneName);
        string newSceneName = currentSceneName.Substring(0, currentSceneName.IndexOf("Workbench")) + "ComicMode";

        EventManager.SetData(GameConstants.OverlapLoadSceneEvent, newSceneName);
        EventManager.EmitEvent(GameConstants.OverlapLoadSceneEvent);
    }
    public void ExitToWorkbenchMode()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        string newSceneName = currentSceneName.Substring(0, currentSceneName.IndexOf("ComicMode")) + "Workbench";
        if (SceneManager.GetSceneByName(newSceneName).isLoaded)
        {
            EventManager.EmitEvent(GameConstants.UnpauseGame);
            EventManager.SetData(GameConstants.UnloadLevelEvent, currentSceneName);
            EventManager.EmitEvent(GameConstants.UnloadLevelEvent);
        }
        else
        {
            EventManager.SetData(GameConstants.LoadLevelEvent, newSceneName);
            EventManager.EmitEvent(GameConstants.LoadLevelEvent);
        }
    }


}
