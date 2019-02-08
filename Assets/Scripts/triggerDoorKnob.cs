using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using System.Collections;

public class triggerMaxWell: VRTK_InteractableObject
{

    AudioSource audio;

    void Start()

    { 

        if (GetComponent<VRTK_InteractableObject>() == null)

        {
            return;

        }

    }



    //this object has been grabbed.. so do what ever is in the code.. 

    public override void StartUsing(VRTK_InteractUse usingObject)

    {

            audio = GetComponent<AudioSource>();
            audio.Play();



        

    }

}