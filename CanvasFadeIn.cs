using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CanvasFadeIn : MonoBehaviour
{

    public Image fadeImage;
    public float fadeDuration = 1.5f;

    private float activeTime;
    private UnityAction callback;
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Clear();
        activeTime = fadeDuration + 1f;
    }

    public void StartFade()
    {
        isActive = true;
        activeTime = 0;
    }

    public void StartFade(UnityAction callback)
    {
        isActive = true;
        this.callback = callback;
        activeTime = 0;
    }

    public void Clear()
    {
        Color targetColor = fadeImage.color;
        targetColor.a = 0f;
        fadeImage.color = targetColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;
        }
        if (activeTime > fadeDuration)
        {
            Color targetColor = fadeImage.color;
            targetColor.a = 0f;
            fadeImage.color = targetColor;
            if (callback != null)
            {
                callback();
                callback = null;
            }
            isActive = false;
            return;
        }

        activeTime += Time.deltaTime;

        var tempColor = fadeImage.color;
        tempColor.a = 1f*(1-(activeTime/fadeDuration));
        fadeImage.color = tempColor;
    }
}
