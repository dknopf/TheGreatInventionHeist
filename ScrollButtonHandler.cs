using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollButtonHandler : MonoBehaviour
{
    public ScrollRect scrollRect;
    public Button topButton;
    public Button bottomButton;
    public Canvas inventoryCanvas;
    private GameObject content;

    void Start()
    {
        content = GameObject.Find("InventoryListContent");
    }

    // Update is called once per frame
    //hides the appropriate button if the scrollRect is at the top/bottom
    void Update()
    {
        //Debug.Log(content.GetComponent<RectTransform>().sizeDelta.y);
        if(content.GetComponent<RectTransform>().sizeDelta.y>((inventoryCanvas.GetComponent<RectTransform>().rect.height-100f)-124))
        {
            if(scrollRect.verticalNormalizedPosition >= 0.95f)
            {
                var tempCol = topButton.GetComponent<Image>().color;
                tempCol.a = 0;
                topButton.GetComponent<Image>().color = tempCol;

                tempCol = bottomButton.GetComponent<Image>().color;
                tempCol.a = 1;
                bottomButton.GetComponent<Image>().color = tempCol;
            }

            else if(scrollRect.verticalNormalizedPosition <= 0.05f)
            {
                var tempCol = bottomButton.GetComponent<Image>().color;
                tempCol.a = 0;
                bottomButton.GetComponent<Image>().color = tempCol;

                tempCol = topButton.GetComponent<Image>().color;
                tempCol.a = 1;
                topButton.GetComponent<Image>().color = tempCol;
            }

            else
            {
                var tempCol = topButton.GetComponent<Image>().color;
                tempCol.a = 1;
                topButton.GetComponent<Image>().color = tempCol;

                tempCol = bottomButton.GetComponent<Image>().color;
                tempCol.a = 1;
                bottomButton.GetComponent<Image>().color = tempCol;
            }
        }
        else
        {
            var tempCol = topButton.GetComponent<Image>().color;
            tempCol.a = 0;
            topButton.GetComponent<Image>().color = tempCol;

            tempCol = bottomButton.GetComponent<Image>().color;
            tempCol.a = 0;
            bottomButton.GetComponent<Image>().color = tempCol;
        }
    }
    //pushes the content to the top of the viewport
    public void toTop()
    {
        scrollRect.verticalNormalizedPosition = 1f;
    }
    //pushes content to the bottom of the viewport
    public void toBottom()
    {
        scrollRect.verticalNormalizedPosition = 0f;
    }
}
