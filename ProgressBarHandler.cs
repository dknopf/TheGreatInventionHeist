using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;
using UnityEngine.SceneManagement;

public class ProgressBarHandler : MonoBehaviour
{
    public int numCombinations;
    private int combosCounter = 0;
    private float barWidth = 606f;
    private Dictionary<string, int> comboDict = new Dictionary<string, int>();


    void Start()
    {
        EventManager.StartListening(GameConstants.SuccessfulPropCreation, incrementProgressBar);

        comboDict.Add("Level0_0", 3);
        comboDict.Add("Level1_1", 6);
        comboDict.Add("Level1_2", 9);
        comboDict.Add("Level1_3", 10);
        comboDict.Add("Level2_1", 6);
        comboDict.Add("Level2_2", 8);

        string sceneName = SceneManager.GetActiveScene().name;
        string level = sceneName.Substring(0, sceneName.IndexOf("Workbench", 0, sceneName.Length));

        numCombinations = comboDict[level];

        RectTransform rt = GetComponent<RectTransform>();
        Vector2 pos = rt.anchoredPosition;
        Vector2 size = rt.sizeDelta;
        size.x = 30;
        rt.sizeDelta = size;

        pos.x = -290;
        rt.anchoredPosition = pos;
    }

    public void incrementProgressBar()
    {
        Image barImage = GetComponent<Image>();
        var tempColor = barImage.color;
        tempColor.a = 1f;
        barImage.color = tempColor;

        RectTransform rt = GetComponent<RectTransform>();

        combosCounter += 1;
        float percentage = (float)combosCounter/numCombinations;
        Vector2 pos = rt.anchoredPosition;
        Vector2 size = rt.sizeDelta;

        if(numCombinations == combosCounter)
        {
            size.x = barWidth;
            rt.sizeDelta = size;

            pos.x = 0f;
            rt.anchoredPosition = pos;
        }
        else
        {
            size.x = barWidth*percentage;
            rt.sizeDelta = size;

            pos.x = (303f*percentage) - 303f;
            rt.anchoredPosition = pos;
        }
    }

}
