using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ChangeScene2 : MonoBehaviour {

    void Start()
    {
        Invoke("Change", 60.0f);
        
    }

    void Change()
    {
        Application.LoadLevel(0);
    }
}
