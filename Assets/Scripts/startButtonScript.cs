using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class startButtonScript : MonoBehaviour
{
    
    public void Skip()
    {
        print("Hello");
        Application.LoadLevel(5); 
    }

}