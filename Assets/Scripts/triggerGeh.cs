using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using System.Collections;

public class triggerGeh : MonoBehaviour {

    

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
        GameVariables.paper_demon_name_geh = true;
        Destroy(gameObject, 2f);

    }
}
