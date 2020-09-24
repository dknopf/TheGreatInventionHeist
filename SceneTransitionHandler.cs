using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using UnityEngine.SceneManagement;

public class SceneTransitionHandler : MonoBehaviour
{
    public CanvasFadeOut FadeOutHandler;
    public CanvasFadeIn FadeInHandler;

    EventsGroup listeners = new EventsGroup();

    // Start is called before the first frame update
    void Start()
    {
        listeners.Add(GameConstants.LoadLevelEvent, LevelSelectionHandler);
        listeners.Add(GameConstants.UnloadLevelEvent, LevelExitHandler);
        listeners.Add(GameConstants.OverlapLoadSceneEvent, OverlapLoadHandler);
        listeners.StartListening();

        if (SceneManager.sceneCount <= 1)
        {
            loadScene(GameConstants.StartSceneName);
        }
        else
        {
            SceneManager.SetActiveScene(GetCurrentScene());
        }
    }

    void LevelSelectionHandler()
    {
        string selectedLevel = EventManager.GetString(GameConstants.LoadLevelEvent);
        Debug.Log(selectedLevel);
        loadScene(selectedLevel);
    }

    void LevelExitHandler()
    {
        string exitLevel = EventManager.GetString(GameConstants.UnloadLevelEvent);
        Scene exitLevelScene = SceneManager.GetSceneByName(exitLevel);
        removeScene(exitLevelScene);
    }

    void OverlapLoadHandler()
    {
        string level = EventManager.GetString(GameConstants.OverlapLoadSceneEvent);
        loadScene(level, overlap: true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void loadScene(string sceneName, bool overlap = false)
    {
        var loadedScenes = GetAllLoadedScenes();
        if(loadedScenes.Count <= 0)
        {
            AsyncOperation oper = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            oper.completed += (asyncOp) =>
            {
                Scene newScene = SceneManager.GetSceneByName(sceneName);
                SceneManager.SetActiveScene(newScene);
                FadeInHandler.StartFade();
            };
            return;
        }

        Scene currentScene = GetCurrentScene();
        EventManager.EmitEvent(GameConstants.PauseGame);
        FadeOutHandler.StartFade(() =>
        {
            AsyncOperation op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            op.completed += (asyncOp) =>
            {
                FadeOutHandler.Clear();
                FadeInHandler.StartFade(() =>
                {
                    //EventManager.EmitEvent(GameConstants.UnpauseGame);
                });
                Scene newScene = SceneManager.GetSceneByName(sceneName);
                SceneManager.SetActiveScene(newScene);
                if (!overlap)
                {
                    foreach (Scene s in loadedScenes)
                    {
                        SceneManager.UnloadSceneAsync(s);
                    }
                    //SceneManager.UnloadSceneAsync(currentScene);
                }
            };
        });
        
    }


    private void removeScene(Scene target)
    {
        AsyncOperation op = SceneManager.UnloadSceneAsync(target);
        op.completed += (asyncOp) =>
        {
            SceneManager.SetActiveScene(GetCurrentScene());
        };
    }

    public List<Scene> GetAllLoadedScenes()
    {
        int countLoaded = SceneManager.sceneCount;
        List<Scene> scenesList = new List<Scene>();
        for (int i = 1; i < countLoaded; i++)
        {
            scenesList.Add(SceneManager.GetSceneAt(i));
        }
        return scenesList;
    }

    public Scene GetCurrentScene()
    {
        var loadedScenes = GetAllLoadedScenes();
        if(loadedScenes.Count <= 0)
        {
            throw new System.Exception("no loaded scenes");
        }
        Scene current = loadedScenes[loadedScenes.Count - 1];
        return current;
    }
}
