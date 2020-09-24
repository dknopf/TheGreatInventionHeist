using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class InventoryColliderTemplate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //EventManager.SetData(GameConstants.PropInventoryCollisonEvent, collision.gameObject);
        //EventManager.EmitEvent(GameConstants.PropInventoryCollisonEvent);
    }
}
