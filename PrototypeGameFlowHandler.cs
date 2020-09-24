using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeGameFlowHandler : GameFlowHandlerTemplate
{
    protected override void LevelInitialization()
    {
        string basePath = PropPrefabNames.Level1_1.folderName + '/';
        var sceneLevel = typeof(PropPrefabNames.Level1_1);
        SetInitialInventoryPropList(new List<string>()
        {
            basePath + PropPrefabNames.Level1_1.heliumProp,
            basePath + PropPrefabNames.Level1_1.hydrogenProp,
            basePath + PropPrefabNames.Level1_1.airProp,
            basePath + PropPrefabNames.Level1_1.canvasProp,
            basePath + PropPrefabNames.Level1_1.tankProp,
            basePath + PropPrefabNames.Level1_1.motorProp,
            basePath + PropPrefabNames.Level1_1.tailfinProp,
            basePath + PropPrefabNames.Level1_1.frameProp,
        });
        SetResponseTable(new GetResponse());
    }
}
