using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Interactable : MonoBehaviour
{
    bool wasReleased = false;
    bool isPaused = false;

    bool isSelected = false;
    public bool fromInventory = false;

    Vector3 offset;

    public Vector3 lastPosition = new Vector3();

    public bool hasCollided = false;
    public bool hasBeenSelectedAtLeastOnce = false;

    //Creates a rectangle size of the screen
    Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);


    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(GameConstants.PauseGame, PauseProps);
        EventManager.StartListening(GameConstants.UnpauseGame, UnpauseProps);
        EventManager.StartListening(GameConstants.RemoveAllPropEvent, RemoveProp);

        lastPosition = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected & screenRect.Contains(Input.mousePosition) & !isPaused)
        {
            MoveToMousePosition();
            if (!Input.GetMouseButton(0))
            {
                DeselectObject();
            }
        }
    }


    void MoveToMousePosition()
    {
        //Gets the position of the mouse and converts it from screen into world position
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        //Changes the objects position to that of the mouse
        this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0) + offset;
    }

    void PauseProps()
    {
        isPaused = true;
    }

    void UnpauseProps()
    {
        isPaused = false;

    }


    //Sets wasReleased = true for 5 frames then sets it false
    //Also sets isTrigger to true so it can't cause additional collisions
    //This way it can be detected if one object was dropped on another
    IEnumerator ExecuteAfterFrames()
    {
        Debug.Log("execute after frames called");
        Debug.Log("isTrigger in top of execute after frames is" + this.GetComponent<Collider2D>().isTrigger);
        wasReleased = true;
        yield return StartCoroutine(WaitFor.Frames(5)); // wait for 5 frames
        wasReleased = false;
        Debug.Log("after wait in executeAfterFrames");
        this.GetComponent<Collider2D>().isTrigger = true;
        lastPosition = gameObject.transform.position;

        if (fromInventory)
        {
            SFXManager.PlaySound("propDrop");
        }
        fromInventory = false;


        //Allows for individual scripts to do unique things when dropped if needed
        SpecialOnDropActions();

    }

    private void OnMouseDown()
    {
        //Debug.Log("mouseDown");
        this.GetComponent<SpriteRenderer>().sortingLayerName = "ActiveProp";

        SelectObject();
        this.GetComponent<Collider2D>().isTrigger = false;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset.z = 0.0f;

        lastPosition = gameObject.transform.position;
        fromInventory = false;

        EventManager.EmitEvent(GameConstants.PropOnPrimaryMouseDownEvent);
    }

    private void OnMouseUp()
    {
        //SFXManager.PlaySound("propDrop");

        //Debug.Log("MouseUp");
        //this.GetComponent<SpriteRenderer>().sortingOrder = 1;
        this.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
        GlobalStaticVariables.topLayer = GlobalStaticVariables.topLayer + 1;
        this.GetComponent<SpriteRenderer>().sortingOrder = GlobalStaticVariables.topLayer;

        isSelected = false;
        //When mouse is released check for collisions
        StartCoroutine("ExecuteAfterFrames");

        EventManager.EmitEvent(GameConstants.PropOnPrimaryMouseUpEvent);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        //Debug.Log("isSlected is " + isSelected);
        Debug.Log("wasReleased is " + wasReleased);
        //Debug.Log("hasCollided is " + hasCollided);
        Debug.Log("other colliders triger status is" + collision.GetComponent<Collider2D>().isTrigger);
        Debug.Log("this triggers status is" + this.GetComponent<Collider2D>().isTrigger);
        if (isSelected)
        {
            Debug.Log("first if statement in trigger stay");

            return;
        }
        //If the object was just dragged and released onto another object
        //hasCollided makes sure it can only collide with one object
        //before it needs to be picked up again
        if (wasReleased == true && !hasCollided)
        {
            if (collision.gameObject.name == GameConstants.InventoryColliderAreaName)
            {
                Debug.Log("second if statement in trigger stay");

                wasReleased = false;
                this.GetComponent<Collider2D>().isTrigger = true;
                EventManager.SetData(GameConstants.PropInventoryCollisonEvent, gameObject);
                EventManager.EmitEvent(GameConstants.PropInventoryCollisonEvent);
                hasCollided = true;
                return;
            }
            else
            {
                Debug.Log("third if statement in trigger stay");

                wasReleased = false;
                this.GetComponent<Collider2D>().isTrigger = true;

                //Sends an array of a single element of the event that this collided with with the event
                EventManager.SetData(GameConstants.PropCollisionEvent, collision.gameObject);
                //Sends the event with this GameObject as the sender
                EventManager.EmitEvent(GameConstants.PropCollisionEvent, this.gameObject);
                hasCollided = true;
                return;
            }
            
        }
        else
        //hasBeenSelectedAtLeastOnce ensures that a prop can't collide with the inventory when it
        //is first created in the workbench via a success
        {

            if (collision.gameObject.name == GameConstants.InventoryColliderAreaName && hasBeenSelectedAtLeastOnce && !hasCollided)
            {
                Debug.Log("fourth if statement in trigger stay");

                Debug.Log("inventory collision without release");
                EventManager.SetData(GameConstants.PropInventoryCollisonEvent, gameObject);
                EventManager.EmitEvent(GameConstants.PropInventoryCollisonEvent);
                return;
            }
        }
    }

    public void returnToLastPosition()
    {
        if (fromInventory)
        {
            EventManager.SetData(GameConstants.PropInventoryCollisonEvent, gameObject);
            EventManager.EmitEvent(GameConstants.PropInventoryCollisonEvent);
            return;
        }
        gameObject.transform.position = lastPosition;
    }

    public void SelectObject()
    {
        isSelected = true;
        hasCollided = false;
        hasBeenSelectedAtLeastOnce = true;
    }

    public void DeselectObject()
    {
        EventManager.EmitEvent(GameConstants.PropOnPrimaryMouseUpEvent);
        isSelected = false;
        StartCoroutine("ExecuteAfterFrames");
    }

    public void SetFromInventory()
    {
        fromInventory = true;
    }

    public void RemoveProp()
    {
        Destroy(gameObject);
    }

    protected virtual void SpecialOnDropActions()
    {

    }
}
