using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class UICollisionEmitter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(GameConstants.PropCollisionEvent, emitter);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void emitter()
    {
        var sender = (GameObject)EventManager.GetSender(GameConstants.PropCollisionEvent);

        GameObject obj1 = sender;
        GameObject obj2 = EventManager.GetGameObject(GameConstants.PropCollisionEvent);

        Debug.Log("Object 2 name: " + obj2.name);

        if(obj2.name != "InventoryCollider")
        {
            EventManager.SetData(GameConstants.RemoveFromInventory, obj1);
            EventManager.EmitEvent(GameConstants.RemoveFromInventory, obj1);
        }
        else
        {
            Debug.Log("Emitted event with attached object " + sender.name);
            EventManager.SetData(GameConstants.AddToInventory, obj1);
            EventManager.EmitEvent(GameConstants.AddToInventory, obj1);
        }
    }
}
