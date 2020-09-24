using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level1_2Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level1_2.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level1_2);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level1_2.frameProp,
            basePath + PropPrefabNames.Level1_2.wheelsProp,
            basePath + PropPrefabNames.Level1_2.propellerProp,
            basePath + PropPrefabNames.Level1_2.clothProp,
            basePath + PropPrefabNames.Level1_2.engineProp,
            basePath + PropPrefabNames.Level1_2.fuelProp,
            basePath + PropPrefabNames.Level1_2.waterProp,
            basePath + PropPrefabNames.Level1_2.aileronProp,
            basePath + PropPrefabNames.Level1_2.elevatorProp,
            basePath + PropPrefabNames.Level1_2.rudderProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level1_2";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level1_2.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
