using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level2_2Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level2_2.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level2_2);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level2_2.positiveTerminalProp,
            basePath + PropPrefabNames.Level2_2.negativeTerminalProp,
            basePath + PropPrefabNames.Level2_2.casingProp,
            basePath + PropPrefabNames.Level2_2.anodeProp,
            basePath + PropPrefabNames.Level2_2.cathodeProp,
            basePath + PropPrefabNames.Level2_2.metalSeparatorProp,
            basePath + PropPrefabNames.Level2_2.clothSeparatorProp,
            basePath + PropPrefabNames.Level2_2.waterProp,
            basePath + PropPrefabNames.Level2_2.sulfuricAcidProp,
            basePath + PropPrefabNames.Level2_2.flashlightProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level2_2";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level2_2.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
