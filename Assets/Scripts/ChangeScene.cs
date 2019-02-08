using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ChangeScene : MonoBehaviour {

    void Start()
    {
        Invoke("Change", 40.0f);
        
    }

    void Change()
    {
        Application.LoadLevel(2);
    }
}
