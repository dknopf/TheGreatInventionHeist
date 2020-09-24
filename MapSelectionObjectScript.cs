using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.EventSystems;

public class MapSelectionObjectScript : MonoBehaviour
{
    public string levelName;
    public string levelID;
    public string status = LevelStatus.unavailable;
    public SpriteRenderer background;
    public SpriteRenderer lockIcon;
    public SpriteRenderer levelIcon;
    public Sprite incompleteBackgroundSprite;
    public Sprite completeBackgroundSprite;
    public Sprite lockSprite;
    public Sprite incompletedLevelIcon;
    public Sprite completedLevelIcon;
    public GameObject lockedModal;

    private EventsGroup listeners = new EventsGroup();
    private Level level;
    private Vector3 highlightScale = new Vector3(1.2f, 1.2f, 0);
    private float timeSinceLastClick;
    private const float clickTolerance = 2f;


    public struct LevelStatus{
        public const string available = "available";
        public const string unavailable = "prerequisites not met";
        public const string completed = "completed";
    };

    private void Start()
    {
        listeners.Add(GameConstants.setLevelStatusEvent, LevelStatusSelectionHandler);
        listeners.StartListening();

        SetLevelFromSave();
        timeSinceLastClick = clickTolerance * 2;
    }

    private void Update()
    {
        if(level != null)
        {
            string newStatus = level.levelStatus;
            status = newStatus;
        }
        else
        {
            SetLevelFromSave();
        }
        UpdateStatus();
        //if (!newStatus.Equals(status))
        //{
        //    status = newStatus;
        //    UpdateStatus();
        //}
    }

    private void SetLevelFromSave()
    {
        Save currentSave = Saving.LoadSave();
        if(currentSave != null)
        {
            this.level = currentSave.getLevelById(levelID);
        }
    }

    private void LevelStatusSelectionHandler()
    {
        string newStatus = EventManager.GetString(GameConstants.setLevelStatusEvent);
        status = newStatus;
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        timeSinceLastClick += Time.deltaTime;
        if(timeSinceLastClick > 2 * clickTolerance)
        {
            lockedModal.SetActive(false);
        }
        switch (status)
        {
            case LevelStatus.available:
                levelIcon.sprite = incompletedLevelIcon;
                background.sprite = incompleteBackgroundSprite;
                lockIcon.sprite = null;
                break;
            case LevelStatus.unavailable:
                levelIcon.sprite = incompletedLevelIcon;
                background.sprite = incompleteBackgroundSprite;
                lockIcon.sprite = lockSprite;
                break;
            case LevelStatus.completed:
                levelIcon.sprite = completedLevelIcon;
                background.sprite = completeBackgroundSprite;
                lockIcon.sprite = null;
                break;
            default:
                throw new System.Exception("Invalid status for Level Selection Object");
        }
    }

    private void OnMouseDown()
    {
        if (GlobalStaticVariables.isPaused)
        {
            return;
        }
        string[] data = { levelName, status };
        EventManager.SetData(GameConstants.LevelSelectedEvent, data);
        EventManager.EmitEvent(GameConstants.LevelSelectedEvent);
        if (status.Equals(LevelStatus.unavailable))
        {
            SFXManager.PlaySound("fail");
            if (timeSinceLastClick < clickTolerance)
            {
                lockedModal.SetActive(true);
            }
            timeSinceLastClick = 0;
        }
        else
        {
            SFXManager.PlaySound("uiClick");
        }
    }

    private void OnMouseEnter()
    {
        if (GlobalStaticVariables.isPaused)
        {
            gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 0);
            return;
        }
        SFXManager.PlaySound("levelHover");
        gameObject.transform.localScale = highlightScale;
    }

    private void OnMouseExit()
    {
        if (GlobalStaticVariables.isPaused)
        {
            gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 0);
            return;
        }
        gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 0);
    }
}
