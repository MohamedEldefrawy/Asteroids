using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Configure teh Screen
/// </summary>
public class ScreenUtils {

    #region Fields
    // cached for efficient boundary checking
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;
    #endregion


    #region Properties
    public static float ScreenLeft
    {
        get
        {
            return screenLeft;
        }

    }

    public static float ScreenRight
    {
        get
        {
            return screenRight;
        }

    }

    public static float ScreenTop
    {
        get
        {
            return screenTop;
        }

    }

    public static float ScreenBottom
    {
        get
        {
            return screenBottom;
        }

    }
    #endregion

    #region Methods
    
    /// <summary>
    /// Initialize the screen utility
    /// </summary>
    public static void Initialize()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 upperRightCorenerScreen = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 lowerLeftCorenerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 upperrightCornerWorld = Camera.main.ScreenToWorldPoint(upperRightCorenerScreen);
        screenLeft = lowerLeftCorenerWorld.x;
        screenBottom = lowerLeftCorenerWorld.y;
        screenRight = upperrightCornerWorld.x;
        screenTop = upperrightCornerWorld.y;
    }    
    #endregion
}
