using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitializeTitleCard : MonoBehaviour
{
    public GameObject upperText;
    public GameObject lowerText;
    public GetTitleCard getCard = new GetTitleCard();
    public Image TitleImage;

    public float AnimationPeriod = 1.0f;

    private float lastAnimationTime;
    private List<Sprite> animationArray = new List<Sprite>();
    private int animationFrame;
    // Start is called before the first frame update
    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        string level = sceneName.Substring(0, sceneName.Length - sceneName.IndexOf("Comic") - 1);
        var (themeText, levelText) = getCard.getTitleCard(level);
        upperText.GetComponent<Text>().text = themeText;
        lowerText.GetComponent<Text>().text = levelText;
        string titleImageName = GameConstants.TitleCardImageNameTemplate.Replace(GameConstants.LevelIDReplacementString, level);
        string frame1ImageName = titleImageName.Replace(GameConstants.TitleCardAnimationFrameReplacementString, "1");
        Sprite titleImage = Resources.Load<Sprite>(GameConstants.TitleCardImagePath + frame1ImageName);
        TitleImage.sprite = titleImage ?? throw new System.Exception("No title image found for " + level);
        InitializeAnimationSpriteArray(level);
        lastAnimationTime = 0;
        animationFrame = 0;
    }

    private void InitializeAnimationSpriteArray(string levelID)
    {
        string titleImageName = GameConstants.TitleCardImageNameTemplate.Replace(GameConstants.LevelIDReplacementString, levelID);
        int frameCount = 1;
        string frame1ImagePath = GameConstants.TitleCardImagePath + titleImageName.Replace(GameConstants.TitleCardAnimationFrameReplacementString, frameCount.ToString());
        Sprite frame = Resources.Load<Sprite>(frame1ImagePath);
        while(frame != null)
        {
            animationArray.Add(frame);
            frameCount++;
            string nextFramePath = titleImageName.Replace(GameConstants.TitleCardAnimationFrameReplacementString, frameCount.ToString());
            frame = Resources.Load<Sprite>(GameConstants.TitleCardImagePath + nextFramePath);
        }
    }

    private void Update()
    {
        if (GlobalStaticVariables.isPaused)
        {
            return;
        }
        if(lastAnimationTime > AnimationPeriod)
        {
            if(animationArray.Count <= 0)
            {
                return;
            }
            TitleImage.sprite = animationArray[animationFrame];
            animationFrame = (animationFrame + 1) % animationArray.Count;
            lastAnimationTime = 0f;
        }
        lastAnimationTime += Time.deltaTime;
    }
}
