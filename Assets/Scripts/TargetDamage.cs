using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VRTK;

public class TargetDamage : MonoBehaviour
{
    private AudioSource audio;


    private void Start()
    {
        
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.Contains("Arrow"))
        {
            TargetHit();
        }
    }

    private void TargetHit()
    {

        audio = GetComponent<AudioSource>();
        audio.Play();
        GameVariables.nbTargets--;
        
        if (GameVariables.nbTargets <= 0)
        {
            Invoke("ChangeLevel", 3.0f);
        }
        else
        {
            Destroy(gameObject, 2f);
            print(GameVariables.nbTargets);
        }

        




    }

    void ChangeLevel()
    {
        Application.LoadLevel(5);
    }

    


}
