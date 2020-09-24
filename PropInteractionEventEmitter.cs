using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class PropInteractionEventEmitter : MonoBehaviour
{
    public bool ShowDebugLog;

    private void OnMouseDown()
    {
        PrintLog("Emit Mouse Click Event; sender: " + gameObject.name);
        EventManager.EmitEvent(GameConstants.PropOnPrimaryMouseDownEvent, gameObject);
    }

    private void OnMouseUp()
    {

        PrintLog("Emit Mouse Up Event; sender: " + gameObject.name);
        EventManager.EmitEvent(GameConstants.PropOnPrimaryMouseUpEvent);
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        PrintLog("Enter Collision between " + gameObject.ToString() + " and " + other.ToString());
        EventManager.EmitEvent(GameConstants.PropCollisionEvent, gameObject);
        EventManager.SetData(GameConstants.PropCollisionEvent, other.gameObject);
    }

    private void PrintLog(string message)
    {
        if (ShowDebugLog)
        {
            Debug.Log(message);
        }
    }
}
