using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class MapModeGameController : MonoBehaviour
{
    private EventsGroup listeners = new EventsGroup();
    private bool initCompleted = false;

    public Save currentSave;

    private CreateModal modalMaker = new CreateModal();


    // Start is called before the first frame update
    void Start()
    {
        listeners.Add(GameConstants.LevelSelectedEvent, LevelSelectionHandler);
        listeners.StartListening();

        EventManager.EmitEvent(GameConstants.UnpauseGame);
        CheckForGameComplete();

    }

    private void Update()
    {
        //if (!initCompleted)
        //{
        //    try
        //    {
        //        EventManager.SetData(GameConstants.LevelCompleteEvent, "level1_1");
        //        EventManager.EmitEvent(GameConstants.LevelCompleteEvent);
        //        InitializeLevelSelectionObjects();
        //        initCompleted = true;
        //    }
        //    catch(System.Exception e)
        //    {
        //        initCompleted = true;
        //        throw e;
        //    }
        //}
    }



    //Checks if there are any levels marked available in the save 
    //and if there aren't any then create the gameCompleteModal
    public void CheckForGameComplete()
    {
        bool isGameComplete = true;
        currentSave = Saving.LoadSave();
        foreach (Level level in currentSave.levels)
        {
            if (level.levelStatus == MapSelectionObjectScript.LevelStatus.available)
            {
                isGameComplete = false;
            }
        }
        if (isGameComplete && !GlobalStaticVariables.hasGameCompleteModalDisplayed)
        {
            modalMaker.CreateMultiPageModal("Level0_1", DialogueConstants.GameComplete.gameCompleteModalText, "Map Mode/UI Assets/gameCompleteImages/gameCompleteImage1", "LevelCompleteModal");
            EventManager.EmitEvent(GameConstants.PauseGame);
            GlobalStaticVariables.hasGameCompleteModalDisplayed = true;
        }
    }


    void LevelSelectionHandler()
    {
        string[] args = (string[])EventManager.GetData(GameConstants.LevelSelectedEvent);
        string selectedLevel = args[0];
        string levelStatus = args[1];
        switch (levelStatus)
        {
            case MapSelectionObjectScript.LevelStatus.available:
                EventManager.SetData(GameConstants.LoadLevelEvent, selectedLevel);
                EventManager.EmitEvent(GameConstants.LoadLevelEvent);
                break;
            case MapSelectionObjectScript.LevelStatus.unavailable:
                break;
            case MapSelectionObjectScript.LevelStatus.completed:
                EventManager.SetData(GameConstants.LoadLevelEvent, selectedLevel);
                EventManager.EmitEvent(GameConstants.LoadLevelEvent);
                break;
            default:
                throw new System.Exception("Invalid status for Level Selection Object");
        }
        
    }

    void InitializeLevelSelectionObjects()
    {
        //if (File.Exists(Application.persistentDataPath + "/gamesave.txt"))
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    FileStream file = File.Open(Application.persistentDataPath + "/gamesave.txt", FileMode.Open);
        //    Save save = (Save)bf.Deserialize(file);
        //    file.Close();
        //}
        //else
        //{
        //    throw new System.Exception("No save file");
        //}
    }


}
