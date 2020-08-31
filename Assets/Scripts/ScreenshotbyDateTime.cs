using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ScreenshotbyDateTime : MonoBehaviour
{
    public TextMeshProUGUI screenshotText;

    public void TakeScreenShot()
    {
        string strDateTime = "PathOfSyndicate_" + DateTime.Now.ToString("yyyy.MM.dd_HHmmss") + ".png";
        ScreenCapture.CaptureScreenshot(strDateTime);
        //Latest screenshot : PathOfSyndicate_2020.08.30_212630.png
        screenshotText.text = "Latest screenshot : " + strDateTime + ".png";
    }
}
