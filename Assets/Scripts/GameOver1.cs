using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameOver1 : MonoBehaviour
{
    AudioSource myAudio;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(100.0f);
        
    }

    void Update()
    {
        
    }
}
