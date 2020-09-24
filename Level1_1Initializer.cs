using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level1_1Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level1_1.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level1_1);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level1_1.frameProp,
            basePath + PropPrefabNames.Level1_1.canvasProp,
            basePath + PropPrefabNames.Level1_1.tankProp,
            basePath + PropPrefabNames.Level1_1.heliumProp,
            basePath + PropPrefabNames.Level1_1.hydrogenProp,
            basePath + PropPrefabNames.Level1_1.airProp,
            basePath + PropPrefabNames.Level1_1.motorProp,
            basePath + PropPrefabNames.Level1_1.tailfinProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level1_1";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level1_1.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
