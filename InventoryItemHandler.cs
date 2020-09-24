using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TigerForge;

public class InventoryItemHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public bool grayedOut = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!grayedOut)
        {
            EventManager.EmitEvent(GameConstants.InventoryPropClickEvent, this.gameObject);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        EventManager.EmitEvent(GameConstants.InventoryItemHoverEvent, this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        EventManager.EmitEvent(GameConstants.InventoryItemDeselectEvent);
    }
}
