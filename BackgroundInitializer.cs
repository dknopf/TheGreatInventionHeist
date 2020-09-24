using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackgroundInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    private string sceneName;
    private string level;
    private string levelNum;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        level = sceneName.Substring(0, sceneName.IndexOf("Workbench", 0, sceneName.Length));
        levelNum = level.Substring(5,3);

        Image background = GetComponent<Image>();
        Sprite img = Resources.Load<Sprite>("UI Assets/Backgrounds/" + levelNum + "Background");

        background.sprite = img;
    }
}
