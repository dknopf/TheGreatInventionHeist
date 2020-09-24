using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level2_1Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level2_1.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level2_1);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level2_1.tungstenFilamentProp,
            basePath + PropPrefabNames.Level2_1.aluminumFilamentProp,
            basePath + PropPrefabNames.Level2_1.wiresProp,
            basePath + PropPrefabNames.Level2_1.glassShellProp,
            basePath + PropPrefabNames.Level2_1.screwcapProp,
            basePath + PropPrefabNames.Level2_1.argonProp,
            basePath + PropPrefabNames.Level2_1.electricalContactProp,
            basePath + PropPrefabNames.Level2_1.lampProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level2_1";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level2_1.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
