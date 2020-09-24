using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class InventorySortingOrder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartListeners();
    }


    private void StartListeners()
    {
        EventManager.StartListening(GameConstants.MisfireAnimationStarted, SendInventoryToFront);
        EventManager.StartListening(GameConstants.MisfireAnimationEnded, SendInventoryToBack);
    }

    private void SendInventoryToFront()
    {
        this.GetComponent<Canvas>().sortingOrder = GlobalStaticVariables.topLayer - 1;
    }
    private void SendInventoryToBack()
    {
        this.GetComponent<Canvas>().sortingOrder = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
