using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSrc;
    public Dictionary<string, string> musicDict = new Dictionary<string, string>();
    private string lastLevel;

    void Start()
    {
        musicDict.Add("Level1_1", GameConstants.SoundFolderPath + "Level1_1Music");
        musicDict.Add("Level1_2", GameConstants.SoundFolderPath + "Level1_2Music");
        musicDict.Add("Level1_3", GameConstants.SoundFolderPath + "Level1_3Music");
        musicDict.Add("MainMenu", GameConstants.SoundFolderPath + "mainTheme");
        musicDict.Add("StartScene", GameConstants.SoundFolderPath + "mainTheme");
        musicDict.Add("MapScene", GameConstants.SoundFolderPath + "mainTheme");
        musicDict.Add("Level0_0", GameConstants.SoundFolderPath + "mainTheme");
        musicDict.Add("Level2_1", GameConstants.SoundFolderPath + "Level2_1Music");
        musicDict.Add("Level2_2", GameConstants.SoundFolderPath + "Level2_2Music");


        EventManager.StartListening(GameConstants.LoadLevelEvent, changeMusic);
        EventManager.StartListening(GameConstants.FinalPropCreationEvent, levelCompleteMusic);

        lastLevel = "StartScene";

        musicSrc.clip = Resources.Load<AudioClip>(musicDict["StartScene"]);
        musicSrc.Play();

    }

    public void changeMusic()
    {
        string selectedLevel = EventManager.GetString(GameConstants.LoadLevelEvent);
        string level;

        if(string.Equals(selectedLevel.Substring(0,1), "L"))
        {
            level = selectedLevel.Substring(0, 8);
        }
        else{
            level = selectedLevel;
        }

        if (!equality(lastLevel, level))
        {
            if (!musicDict.ContainsKey(level))
            {
                Debug.Log("no music found for level: " + level);
                return;
            }
            musicSrc.clip = Resources.Load<AudioClip>(musicDict[level]);
            musicSrc.Play();
        }

        lastLevel = level;


    }

    private void levelCompleteMusic()
    {
        musicSrc.clip = Resources.Load<AudioClip>("Sounds/levelComplete");
        musicSrc.Play();
    }

    public void stop()
    {
        musicSrc.Stop();
    }

    private void Update()
    {
        musicSrc.volume = GlobalStaticVariables.musicVolume;
    }

    private bool equality(string name1, string name2)
    {
        if(string.Equals(name1, name2))
        {
            return true;
        }
        else if(string.Equals(name1, "StartScene") && string.Equals(name2, "MapScene") | string.Equals(name1, "StartScene") && string.Equals(name2, "Level0_0"))
        {
            return true;
        }
        else if((string.Equals(name1, "MainMenu") && string.Equals(name2, "MapScene")) | (string.Equals(name1, "MapScene") && string.Equals(name2, "MainMenu")))
        {
            return true;
        }
        else{
            return false;
        }
    }
}
