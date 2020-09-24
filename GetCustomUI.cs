using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class GetCustomUI
{
    public Dictionary<string, Dictionary<string, (string, string)>> masterDict = new Dictionary<string, Dictionary<string, (string, string)>>();

    public Dictionary<string, (string, string)> Level0_0Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_1Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_2Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_3Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_1Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_2Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_3Dict = new Dictionary<string, (string, string)>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GetCustomUI()
    {
        SetUpDict();
    }

    public void SetUpDict()
    {
        //Level0_0
        Level0_0Dict.Add("mainColor", ("#484848", "#292929"));
        Level0_0Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level0_0Dict.Add("progressBarTop", ("#969696", "null"));
        Level0_0Dict.Add("progressBarBottom", ("#484848", "null"));
        Level0_0Dict.Add("dialogueBoxX", ("#484848", "null"));
        
        Level1_1Dict.Add("mainColor", ("#4F4131", "#231D15"));
        Level1_1Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level1_1Dict.Add("progressBarTop", ("#876F54", "null"));
        Level1_1Dict.Add("progressBarBottom", ("#4F4131", "null"));
        Level1_1Dict.Add("dialogueBoxX", ("#81694A", "null"));


        Level1_2Dict.Add("mainColor", ("#6E905B", "#4A613D"));
        Level1_2Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level1_2Dict.Add("progressBarTop", ("#97B488", "null"));
        Level1_2Dict.Add("progressBarBottom", ("#6E905B", "null"));
        Level1_2Dict.Add("dialogueBoxX", ("#32241C", "null"));


        Level1_3Dict.Add("mainColor", ("#22BDC9", "#1B98A1"));
        Level1_3Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level1_3Dict.Add("progressBarTop", ("#22929B", "null"));
        Level1_3Dict.Add("progressBarBottom", ("#22BDC9", "null"));
        Level1_3Dict.Add("dialogueBoxX", ("#787573", "null"));

        Level2_1Dict.Add("mainColor", ("#2C4F3D", "#50906F"));
        Level2_1Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level2_1Dict.Add("progressBarTop", ("#498366", "null"));
        Level2_1Dict.Add("progressBarBottom", ("#2C4F3D", "null"));
        Level2_1Dict.Add("dialogueBoxX", ("#3B6B53", "null"));

        Level2_2Dict.Add("mainColor", ("#549C3A", "#539938"));
        Level2_2Dict.Add("tooltipText", ("#FFFFFF", "null"));
        Level2_2Dict.Add("progressBarTop", ("#63B744", "null"));
        Level2_2Dict.Add("progressBarBottom", ("#549C3A", "null"));
        Level2_2Dict.Add("dialogueBoxX", ("#7E7D7D", "null"));


        masterDict.Add("Level0_0", Level0_0Dict);
        masterDict.Add("Level1_1", Level1_1Dict);
        masterDict.Add("Level1_2", Level1_2Dict);
        masterDict.Add("Level1_3", Level1_3Dict);
        masterDict.Add("Level2_1", Level2_1Dict);
        masterDict.Add("Level2_2", Level2_2Dict);



    }


    public Dictionary<string, (string, string)> getCustomUIDict(string level)
    {
        return masterDict[level];
    }


    public List<KeyValuePair<string, (string,string)>> getCustomUI(string level)
    {
        List<KeyValuePair<string, (string, string)>> entryList = new List<KeyValuePair<string, (string, string)>>();
        foreach (KeyValuePair<string, (string, string)> dictEntry in masterDict[level])
        {
            entryList.Add(dictEntry);
        }
        return entryList;
    }


}
