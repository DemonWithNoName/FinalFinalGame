using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollider : MonoBehaviour {

    private void Start()
    {
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
        print("Hallo");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if (collision.collider.name.Contains("Camera"))
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());

        }
    }
}
