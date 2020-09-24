using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayAnimation : MonoBehaviour
{
    public Image ImageTarget;
    public float AnimationPeriod = 5.0f;
    public Sprite[] AnimationFrames;
    public bool loop = false;

    private int frameCount;
    private int animationFrameIndex;
    private float timeSinceLastFrameUpdate = 0f;
    private float singleFrameTime;

    // Start is called before the first frame update
    void Start()
    {
        frameCount = AnimationFrames.Length;
        if(frameCount <= 0)
        {
            throw new System.Exception("No animation frames");
        }
        ImageTarget.sprite = AnimationFrames[0];
        singleFrameTime = AnimationPeriod / frameCount;
        animationFrameIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(animationFrameIndex >= frameCount-1)
        {
            if (loop)
            {
                animationFrameIndex = -1;
            }
            else
            {
                return;
            }
        }
        if(timeSinceLastFrameUpdate > singleFrameTime)
        {
            animationFrameIndex += 1;
            ImageTarget.sprite = AnimationFrames[animationFrameIndex];
            timeSinceLastFrameUpdate = 0f;
        }
        timeSinceLastFrameUpdate += Time.deltaTime;
    }

}
