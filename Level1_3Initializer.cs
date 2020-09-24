using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class Level1_3Initializer : GameFlowHandlerTemplate
{
    private CreateModal modalMaker = new CreateModal();

    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level1_3.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level1_3);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level1_3.launchProp,
            basePath + PropPrefabNames.Level1_3.heliumProp,
            basePath + PropPrefabNames.Level1_3.oxidizerProp,
            basePath + PropPrefabNames.Level1_3.petroleumProp,
            basePath + PropPrefabNames.Level1_3.valvesProp,
            basePath + PropPrefabNames.Level1_3.frameProp,
            basePath + PropPrefabNames.Level1_3.igniterProp,
            basePath + PropPrefabNames.Level1_3.finsProp,
            basePath + PropPrefabNames.Level1_3.payloadProp,
            basePath + PropPrefabNames.Level1_3.emptyChamberProp,
            basePath + PropPrefabNames.Level1_3.computerProp,
            basePath + PropPrefabNames.Level1_3.codeProp,
        });
        SetResponseTable(new GetResponse());
        string level = "Level1_3";
        string levelNum = level.Substring(level.IndexOf("Level"), 3);
        Debug.Log("level1_3 initializer got to the part that instantiates the modal");
        modalMaker.CreateMultiPageModal(level, DialogueConstants.Level1_3.loadInDialogue, level + "/Sprites/" + levelNum + "Inventor", GameConstants.LoadInModal);
    }
}
