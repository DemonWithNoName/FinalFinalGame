using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using System.Collections;

public class triggerDoorKnob2 : VRTK_InteractableObject
{

    AudioSource audio;
    public AudioClip noObjClip;
    public AudioClip successClip;

    private float timeStart;
    private float timeStop;

    void Start()

    {

        timeStart = Time.time;

        if (GetComponent<VRTK_InteractableObject>() == null)

        {
            return;

        }

    }


    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        audio = GetComponent<AudioSource>();
        if (GameVariables.key == true && GameVariables.paper_demon_name_loh == true && GameVariables.donut == true && GameVariables.bow == true)
        {
            audio.clip = successClip;
            audio.Play();
            timeStop = Time.time - timeStart;
            GameVariables.time = timeStop;
            Application.LoadLevel(4);
            return;
        }
        else if(GameVariables.key == false)
        {
            // trigger Sound "The door is locked. I have to find the key"
            audio.Play();
        }
        else
        {
            // trigger Sound "I think I don't have everything. I have a look on the board again."
            audio.clip = noObjClip;
            audio.Play();

        }




    }

}