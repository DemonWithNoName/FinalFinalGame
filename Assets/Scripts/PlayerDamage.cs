using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    private float breakForce = 150f;
    private int playerLife = 5;
    AudioSource audio;
    public AudioClip playerDeadSound;

    private void Start()
    {
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if (collision.collider.name.Contains("DemonPower(Clone)"))
        {
            PlayerHit();
            Destroy(collision.collider.gameObject);
        }

        if (collision.collider.name.Contains("Arrow"))
        {
            print("Collider");
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
           
        }
    }



    private void PlayerHit()
    {

        audio = GetComponent<AudioSource>();
        playerLife = playerLife - 1;

        if (playerLife == 0)
        {
            audio.clip = playerDeadSound;
            audio.volume = 0.75f;
            audio.Play();
            Application.LoadLevel(8);
            return;

        }

        audio.Play();
    }
}
