using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level0_0Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level0_0.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level0_0);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level0_0.frameProp,
            basePath + PropPrefabNames.Level0_0.sidingProp,
            basePath + PropPrefabNames.Level0_0.fluxAntennaProp,
            basePath + PropPrefabNames.Level0_0.warpGeneratorProp,
            basePath + PropPrefabNames.Level0_0.screenProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level0_0";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level0_0.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
