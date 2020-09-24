using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStaticVariables : MonoBehaviour
{
    //Global changeable variable
    public static int topLayer = 0;
    public static bool isPaused = false;
    public static float musicVolume = 0.5f;
    public static float sfxVolume = 0.5f;

    public static bool onMultiPageModalScreen = false;

    public static bool hasGameCompleteModalDisplayed = false;

}
