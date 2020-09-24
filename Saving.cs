using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Saving : MonoBehaviour
{

    public bool ClearSaveOnStart = false;
    public Save currentSave;

    // Start is called before the first frame update
    void Start()
    {
        SetUp();
        currentSave = Saving.LoadSave();
        if (ClearSaveOnStart)
        {
            clearSave();
        }
    }

    public void SetUp()
    {
        EventManager.StartListening(GameConstants.LevelCompleteEvent, OnEventReceived);
        EventManager.StartListening(GameConstants.ClearSaveEvent, clearSave);
    }

    public void OnEventReceived()
    {
        Debug.Log("Saving received LevelCompleteEvent");
        if(currentSave == null)
        {
            currentSave = Saving.LoadSave();
        }
        string levelCompletedId = EventManager.GetString(GameConstants.LevelCompleteEvent);
        Level completedLevel = currentSave.getLevelById(levelCompletedId);
        completedLevel.setLevelStatus(2);
        SaveGame();
    }

    public static Save LoadSave()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.txt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.txt", FileMode.Open);
            SaveData save = (SaveData)bf.Deserialize(file);
            file.Close();

            return new Save(save);
        }
        else
        {
            return new Save();
        }
    }

    public void SaveGame()
    {
        //Turns the save class into binary and saves it to a file
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.txt");
        bf.Serialize(file, currentSave.GenerateSaveData());
        file.Close();

        //Emits event so that the game knows saving has finished successfully
        Debug.Log("Saving is emitting SavingCompleteEvent");
        EventManager.EmitEvent(GameConstants.SavingCompleteEvent);
        //For testing purposes
        //LoadGame();
    }

    private void clearSave()
    {
        currentSave = new Save();
        SaveGame();
    }

    public Save getCurrentSave()
    {
        return currentSave;
    }



    ////Testing to make sure that loading works
    //void LoadGame()
    //{
    //    if (File.Exists(Application.persistentDataPath + "/gamesave.txt"))
    //    {

    //        // 2
    //        BinaryFormatter bf = new BinaryFormatter();
    //        FileStream file = File.Open(Application.persistentDataPath + "/gamesave.txt", FileMode.Open);
    //        Save save = (Save)bf.Deserialize(file);
    //        file.Close();

    //        Debug.Log(save.completeLevels[0]);
    //    }
    //    else
    //    {
    //        Debug.Log("No game saved");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentSave.levels[0].levelStatus);
    }
}
