using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLevelCompleteText
{
    public Dictionary<string, string> levelCompleteText = new Dictionary<string, string>();

    public GetLevelCompleteText()
    {
        SetUpDict();
    }


    public void SetUpDict()
    {
        levelCompleteText.Add("Level0_0", "Hm, what’s this? It seems like EVIL Inc. accidentally left behind their EVIL plan! Go stop their Great Invention Heist and save the world!");
        levelCompleteText.Add("Level1_1", "Thank you for helping me invent a blimp! The sky is no longer the limit!");
        levelCompleteText.Add("Level1_2", "Gee whiz, it seems like we've made the worlds first flying machine!");
        levelCompleteText.Add("Level1_3", "With your help, we can now send astronauts to the moon!");
        levelCompleteText.Add("Level2_1", "Thanks to you, we’ve created a way to provide light for the whole world! The future is looking pretty bright!");
        levelCompleteText.Add("Level2_2", "Thank you for your help, friend, I’m feeling all amped up about the future now!");
        levelCompleteText.Add("Level2_3", "");
    }
    // Update is called once per frame

    public string getLevelCompleteText(string level)
    {
        return levelCompleteText[level];
    }
}
