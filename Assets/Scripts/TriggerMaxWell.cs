using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TriggerMaxWell : MonoBehaviour
{

    AudioSource audio;

    void Start()

    {

        if (GetComponent<VRTK_InteractableObject>() == null)

        {
            return;

        }

        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);

    }



    //this object has been grabbed.. so do what ever is in the code.. 

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)

    {
        audio = GetComponent<AudioSource>();
        audio.Play();

    }
}