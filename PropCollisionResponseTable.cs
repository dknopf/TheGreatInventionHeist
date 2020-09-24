using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropCollisionResponseTable
{
    public const string MisfireResponseID = "misfire";
    public const string FailStateResponseID = "failstate";
    public const string PropMergeResponseID = "prop merged";

    // returns a (responseID, dialog, resultingProp) tuple for the resulting prop collision
    // responseID should correspond with one of the 3 resulting states
    // dialog should contain the dialog to be sent to the UI or null if not applicable
    // resultingProp should contain the resulting object of the prop merge or nulll if not applicable
    public virtual (string responseID, string dialog, GameObject resultingProp, bool isLearnMore)
        getResponse(GameObject prop1, GameObject prop2)
    {
        return (FailStateResponseID, null, null, false);
    }
}
