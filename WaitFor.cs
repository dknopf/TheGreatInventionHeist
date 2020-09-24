using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WaitFor
{

    //Waits for a certain number of frames
    public static IEnumerator Frames(int frameCount)
    {

        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}
