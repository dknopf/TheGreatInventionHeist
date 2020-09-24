using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class SpecialDropActions : Interactable
{

    bool firstDropHappened = false;
    // Start is called before the first frame update

    protected override void SpecialOnDropActions()
    {
        switch (this.name)
        {
            //If attatched to the frame prop in the tutorial
            case "frameProp":
                if (!firstDropHappened)
                {
                    EventManager.SetDataGroup(GameConstants.DisplayDialog, DialogueConstants.Level0_0.frameDraggedIn, "Happy", false);
                    EventManager.EmitEvent(GameConstants.DisplayDialog);
                    firstDropHappened = true;
                }
                break;
        }
    }
}
