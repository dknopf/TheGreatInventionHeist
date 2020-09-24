using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTitleCard 
{

    public Dictionary<string, (string, string)> MasterDict = new Dictionary<string, (string, string)>();

    public GetTitleCard()
    {
        SetUpDict();
    }

    public void SetUpDict()
    {
        MasterDict.Add("Level0_0", ("timegeneering", "level 0: time machine"));
        MasterDict.Add("Level1_1", ("aero engineering", "level 1: blimp"));
        MasterDict.Add("Level1_2", ("aero engineering", "level 2: airplane"));
        MasterDict.Add("Level1_3", ("aero engineering", "level 3: rocket"));
        MasterDict.Add("Level2_1", ("electrical engineering", "level 1: lightbulb"));
        MasterDict.Add("Level2_2", ("electrical engineering", "level 2: battery"));
        MasterDict.Add("Level2_3", ("electrical engineering", "level 3: electric motor"));
    }

    public (string, string) getTitleCard(string level)
    {
        return MasterDict[level];
    }
}
