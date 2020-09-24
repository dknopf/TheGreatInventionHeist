using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnfilledButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    private Text myText;
    private Color myTextColor;
    private Image unfilledButtonImage;
    private GameObject childObject;

    void Start()
    {
        childObject = this.transform.GetChild(0).gameObject;
        
        //myTextColor = childObject.GetComponent<Text>().color;
        unfilledButtonImage = gameObject.GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Color buttonColor = unfilledButtonImage.color;
        buttonColor.a = 1.0f;
        unfilledButtonImage.color = buttonColor;
        //childObject.GetComponent<Text>().color = new Color (110f, 203f, 211f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Color buttonColor = unfilledButtonImage.color;
        buttonColor.a = 0.0f;
        unfilledButtonImage.color = buttonColor;
        //childObject.GetComponent<Text>().color = myTextColor;
    }
}
