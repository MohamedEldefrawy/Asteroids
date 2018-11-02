using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initialize The Game World Screen
/// </summary>
public class GameInitializer : MonoBehaviour {

    private void Awake()
    {
        ScreenUtils.Initialize();
    }
}
