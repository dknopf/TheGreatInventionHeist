public class GameConstants
{



    // Event constants
    public const string PropCollisionEvent          = "Prop Collision Trigger";
    public const string PropOnPrimaryMouseDownEvent = "On Mouse Click Trigger on Prop";
    public const string PropOnPrimaryMouseHoldEvent = "On Mouse Hold Trigger on Prop";
    public const string PropOnPrimaryMouseUpEvent   = "On Mouse Up Trigger on Prop";
    public const string PauseGame                   = "Pause Game";
    public const string UnpauseGame                 = "Unpause Game";
    public const string PropInventoryCollisonEvent  = "Prop Inventory Collision";
    public const string PropAnimationFinishedEvent  = "Prop Animation Finished";
    public const string ClearSaveEvent              = "Clear Save";
    public const string StartSaveEvent              = "Start Save";
    public const string SavingCompleteEvent         = "Saving complete";
    public const string SuccessfulPropCreation      = "Prop Created";
    public const string FailedPropCollisionEvent    = "Fail Collision";
    public const string FinalPropCompleteEvent      = "Final Prop Complete";
    public const string LearnMoreInteractionEvent   = "Learn More";
    public const string LearnMoreClosedEvent        = "Learn More Box Closed";
    public const string LoadInModalClosedEvent      = "Load In Modal Closed";
    public const string ChangeModalPageClickedEvent = "Change Modal Page Clicked";
    public const string ChangeModalPageEvent        = "Change The Actual Modal Page";
    public const string DisplayLoadInModal          = "Display The Load In Modal";
    public const string FinalPropCreationEvent      = "final prop created";
    public const string RemoveAllPropEvent          = "Remove all props from workbench";
    public const string MisfireAnimationStarted     = "Misfire Animation Started";
    public const string MisfireAnimationEnded       = "Misfire Animation Ended";
    public const string TriggerDialogBoxVisualCue   = "Trigger Dialog Box Visual Cue";
    public const string SetCustomUI                 = "Set Custom UI";
    public const string GameCompleteEvent           = "Game is complete!";


    // Scene transition constants
    public const string LevelCompleteEvent          = "Level Complete";
    public const string LevelExitEvent              = "Exiting level";
    public const string LevelSelectedEvent          = "Level selected";
    public const string LoadLevelEvent              = "Load level";
    public const string UnloadLevelEvent            = "Unload level";
    public const string OverlapLoadSceneEvent       = "Overlap load";

    // UI constants
    public const string InventoryPropClickEvent     = "Prop in Inventory was clicked";
    public const string InitializeInventoryEvent    = "Initialize Inventory";
    public const string ClearInventoryEvent         = "Clear Inventory";
    public const string DisplayDialog               = "Display Dialog";
    public const string AddToInventory              = "Add object to inventory";
    public const string RemoveFromInventory         = "Remove object from inventory";
    public const string InventoryPropPrefabPath     = "GlobalPrefabs/InventoryPropTemplate";
    public const string InventoryListContentName    = "InventoryListContent";
    public const string InventorySpriteFolderName   = "UI Assets";
    public const string InventoryItemHoverEvent     = "Inventory Item Hovered";
    public const string InventoryItemDeselectEvent  = "Stopped Inventory Item Hover";
    public const string SpriteFolderPath            = "/Sprites/";


    // Comic Mode UI Constants
    public const string ChangePageClickedEvent      = "A Change Page Button Was Clicked";
    public const string SetInventorEvent            = "Set The Inventor Image";
    public const string ChangePageEvent             = "Change the Page";
    public const string ComicFramePath              = "/comicmode/";
    public const string FirstPageStatus             = "On First Page";
    public const string LastPageStatus              = "On Last Page";
    public const string MiddlePageStatus            = "In The Middle";
    public const string SoundFolderPath             = "Sounds/";
    public const string TitleCardClosed             = "Title Card Closed";

    //Modal name constants
    public const string LoadInModal                 = "LoadInModal";
    public const string LearnMoreModal              = "LearnMoreModal";

    // Map Scene Constants
    public const string setLevelStatusEvent         = "set level status";

    // Layer constants
    public const int WorkbenchLayer = 9;
    public const int MovingPropLayer = 8;

    // Collision Area Name
    public const string InventoryColliderAreaName   = "InventoryCollider";

    // Scene Names
    public const string StartSceneName              = "StartScene";
    public const string MainMenuSceneName           = "MainMenu";
    public const string MapSceneName                = "MapScene";
    public const string PrototypeLevelSceneName     = "PrototypeLevelMaster";
    public const string SceneTransitionTest1        = "Scene1";
    public const string SceneTransitionTest2        = "Scene2";
    public const string Level1_1WorkBench           = "Level1_1Workbench";
    public const string Level0_0Comic               = "Level0_0ComicMode";

    // Sound constants
    public const string MusicVolumeChangeEvent      = "Change music volume change";
    public const string SfxVolumeChangeEvents       = "sound effect volume change";
    public const string PlaySFXEvent                = "Play sfx";

    // Title card constants
    public const string TitleCardImagePath          = "UI Assets/Level Title Screens/";
    public const string TitleCardImageNameTemplate  = "%levelID%TitleScreen_%animation_frame%";
    public const string LevelIDReplacementString    = "%levelID%";
    public const string TitleCardAnimationFrameReplacementString = "%animation_frame%";

}
