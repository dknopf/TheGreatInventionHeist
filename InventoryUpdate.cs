using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class InventoryUpdate : MonoBehaviour
{
    public GameObject prefab;
    private GameObject inventoryListContent;
    void Start()
    {
        prefab = Resources.Load<GameObject>(GameConstants.InventoryPropPrefabPath);

        EventManager.StartListening(GameConstants.AddToInventory, addToInventory);
        EventManager.StartListening(GameConstants.RemoveFromInventory, removeFromInventory);
        EventManager.StartListening(GameConstants.InitializeInventoryEvent, InitializeInventory);
        EventManager.StartListening(GameConstants.ClearInventoryEvent, DeactivateInventory);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InitializeInventory()
    {
        GameObject[] inventoryList = (GameObject[])EventManager.GetData(GameConstants.InitializeInventoryEvent);
        foreach(GameObject prop in inventoryList)
        {
            WorkbenchPropToInventoryProp(prop);
        }
    }

    private void addToInventory()
    {
        Debug.Log("got into top of add to inevntory in invetory update");
        //GameObject newObj;
        var eventData = EventManager.GetDataGroup(GameConstants.AddToInventory);
        GameObject sender = eventData[0].ToGameObject();
        bool initialPropOrNot = eventData[1].ToBool();

        if (initialPropOrNot)
        {
            WorkbenchPropToReenableInventoryProp(sender);

        }
        else
        {
            WorkbenchPropToInventoryProp(sender);
        }



        //SpriteRenderer senderRender = sender.GetComponent<SpriteRenderer>();
        //Sprite senderSprite = senderRender.sprite;

        //string senderName = sender.name;
        //string senderTag = sender.tag;
        //string newName = "inv" + senderName;

        //newObj = (GameObject)Instantiate(prefab, transform);


        //newObj.GetComponent<Image>().sprite = senderSprite;
        //newObj.name = senderName;
        //newObj.tag = senderTag;

        //Destroy(sender);
    }



    private void removeFromInventory()
    {
        var eventData = EventManager.GetDataGroup(GameConstants.RemoveFromInventory);
        GameObject sender = eventData[0].ToGameObject();
        bool initialPropOrNot = eventData[1].ToBool();

        if (initialPropOrNot)
        {
            grayOutProp(sender);
        }
        else
        {
            destroyInventoryProp(sender);
        }
    }

    private void destroyInventoryProp(GameObject sender)
    {
        var targetObject = gameObject.transform.Find(sender.name).gameObject;
        Destroy(targetObject);
    }


    IEnumerator FadeAlphaOut(Color start, Color end, float duration, GameObject sender)
    {

        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            float normalizedTime = t / duration;
            //right here, you can now use normalizedTime as the third parameter in any Lerp from start to end
            sender.GetComponent<Image>().color = Color.Lerp(start, end, normalizedTime);
            yield return null;
        }
        sender.GetComponent<Image>().color = end; //without this, the value will end at something like 0.9992367
    }
    private void grayOutProp(GameObject sender)
    {
        Color propColor = sender.GetComponent<Image>().color;
        StartCoroutine(FadeAlphaOut(propColor, new Color(propColor.r, propColor.g, propColor.b, 0.33f), 0.02f, sender));
        sender.GetComponent<InventoryItemHandler>().grayedOut = true;

    }


    public GameObject WorkbenchPropToInventoryProp(GameObject workbenchProp)
    {
        GameObject targetObject = Instantiate(prefab, transform);
        string name = workbenchProp.name;
        string tag = workbenchProp.tag;
        string level = tag.Substring(0, tag.IndexOf("P"));
        string spriteName = name.Remove(name.IndexOf("Prop")) + "Text";
        //Debug.Log("Level in inventory update is " + level + "Sprites/" + spriteName);

        Sprite inventorySprite = Resources.Load<Sprite>(level + "Sprites/Inventory Sprites/" + spriteName);
        targetObject.name = name;
        targetObject.tag = tag;
        targetObject.GetComponent<Image>().sprite = inventorySprite;
        return targetObject;
    }

    public void WorkbenchPropToReenableInventoryProp (GameObject workbenchProp)
    {
        Debug.Log("got into top of workbenchPropReenable in inventory update");
        string propName = workbenchProp.name;
        workbenchProp.name = "tempName";
        GameObject inventoryProp = GameObject.Find(propName);
        Color propColor = inventoryProp.GetComponent<Image>().color;
        propColor.a = 1.0f;
        inventoryProp.GetComponent<Image>().color = propColor;
        inventoryProp.GetComponent<InventoryItemHandler>().grayedOut = false;
    }

    private void DeactivateInventory()
    {
        gameObject.SetActive(false);
    }
}
