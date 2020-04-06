using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceCheckerScript : MonoBehaviour
{
    public static bool devChecker = false; //if it's true the selected device is PC, but when it's false it is 
                                           //                                                           Android.
    void Start()
    {
            #if UNITY_STANDALONE_WIN
        devChecker = true;
        print(devChecker);
                   #endif
    }


}
