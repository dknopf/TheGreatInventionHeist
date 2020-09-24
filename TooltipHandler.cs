using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;
using System;

public class TooltipHandler : MonoBehaviour
{
    public Canvas tooltipCanvas;
    public Text textBox;
    public ScrollRect scroller;
    public Camera cam;
    private GetTooltip gr = new GetTooltip();
    private Vector2 zeroVel = new Vector2(0f,0f);
    private bool propDrag;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(GameConstants.InventoryItemHoverEvent, moveTooltip);
        EventManager.StartListening(GameConstants.InventoryItemDeselectEvent, removeTooltip);
        EventManager.StartListening(GameConstants.InventoryPropClickEvent, removeTooltip);
        EventManager.StartListening(GameConstants.PropOnPrimaryMouseUpEvent, propDown);
        EventManager.StartListening(GameConstants.InventoryPropClickEvent, propUp);
        EventManager.StartListening(GameConstants.PropOnPrimaryMouseDownEvent, propUp);
        this.gameObject.SetActive(false);
        propDrag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!propDrag){
            moveTooltip();
        }
    }

    private void moveTooltip()
    {
        if (!GlobalStaticVariables.isPaused)
        {
            if(!propDrag){
                this.gameObject.SetActive(true);
            }

            GameObject sender = (GameObject)EventManager.GetSender(GameConstants.InventoryItemHoverEvent);

            string senderName = sender.name;

            string level = sender.tag.Substring(0, sender.tag.IndexOf("/", 0, sender.tag.Length));

            RectTransform rt = GetComponent<RectTransform>();
            RectTransform rtSender = sender.GetComponent<RectTransform>();
            RectTransform rtCanvas = tooltipCanvas.GetComponent<RectTransform>();

            Vector2 senderPos = rtSender.position;
            Vector2 senderSize = rtSender.sizeDelta;
            Vector2 size = rt.sizeDelta;

            senderPos = cam.WorldToScreenPoint(senderPos);

            senderPos.x = 315;
            senderPos.y /= tooltipCanvas.scaleFactor;

            //Debug.Log("scale: " + tooltipCanvas.scaleFactor + " clamp values: " + 160f*tooltipCanvas.scaleFactor);

            senderPos.y = Mathf.Clamp(senderPos.y, 90f, rtCanvas.rect.height-90f);

            rt.anchoredPosition = senderPos;

            string tooltip = gr.getTooltip(level, senderName);

            textBox.text = tooltip;
        }

    }
    private void removeTooltip()
    {
        this.gameObject.SetActive(false);
    }
    private void propUp()
    {
        propDrag = true;
    }
    private void propDown()
    {
        propDrag = false;
    }
}
