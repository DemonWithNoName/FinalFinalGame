using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class skipScript : MonoBehaviour
{
    
    public void Skip()
    {
        Application.LoadLevel(2);
    }

}