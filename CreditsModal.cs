using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreditsModal : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string secretDescription;
    public Text descriptionText;
    public Image inventorSprite;
    public Sprite alternateSprite;

    private Sprite originalSprite;
    private bool DisplaySecretDescription = false;
    private string originalText;

    private void Start()
    {
        originalText = descriptionText.text;
        originalSprite = inventorSprite.sprite;
    }

    public void ToggleSecretText()
    {
        if (DisplaySecretDescription)
        {
            descriptionText.text = originalText;
            DisplaySecretDescription = false;
        }
        else
        {
            descriptionText.text = secretDescription;
            DisplaySecretDescription = true;
        }
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        descriptionText.text = secretDescription;
        inventorSprite.sprite = alternateSprite;
        DisplaySecretDescription = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        descriptionText.text = originalText;
        inventorSprite.sprite = originalSprite;
        DisplaySecretDescription = false;
    }
}
