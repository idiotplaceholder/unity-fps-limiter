using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpslimiter : MonoBehaviour
{
    //If customframerate is set to 0, frame limiter is disabled
    public int customframerate;

    void Update()
    {
        //If vSync is enabled, the frame limiter won't work
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = customframerate;
    }
}
