using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level2_3Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level2_3.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level2_3);
        SetInitialInventoryPropList(new List<string>()
        {
            //basePath + PropPrefabNames.Level2_3.payloadProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level2_3";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level2_3.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
