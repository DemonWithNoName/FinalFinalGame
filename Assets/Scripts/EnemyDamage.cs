using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VRTK;

public class EnemyDamage : MonoBehaviour
{
    public AudioClip demonDeadSound;
    public GameObject demonBall;
    public float speedPower;
    public GameObject[] waypointsPower;

    private int demonLife = 5;

    private Animator animator;
    private AudioSource audio;

    private int randomNb;
    private int frames;
    private int current = 0;
    private float rotSpeed;
    private float WPradius = 1;
    private bool objVisible = false;
    private bool isCopied = true;
    int waitFrames = 0;


    GameObject demonBallCopy;

    private float timeStart;
    private float timeStop;

    private void Start()
    {
        timeStart = Time.time;
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    private void Update()
    {
        animator = GetComponent<Animator>();

        if (randomNb == 0)
        {
            System.Random rnd = new System.Random();
            randomNb = rnd.Next(150, 350);
        }
        if (randomNb == frames)
        {
            if (objVisible == false)
            {
                
                animator.SetBool("attack", true);  
                objVisible = true;
                isCopied = false;
                

            }

            if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Attack")
            {
                if (isCopied == false)
                {
                    waitFrames++;
                    if (waitFrames == 25)
                    {
                        demonBallCopy = Instantiate(demonBall, waypointsPower[0].transform.position, Quaternion.identity);

                        isCopied = true;
                        waitFrames = 0;
                    }
                }
                animator.SetBool("attack", false);
            }
            

            if (demonBallCopy != null)
            {

                demonBallCopy.transform.position = Vector3.MoveTowards(demonBallCopy.transform.position, waypointsPower[1].transform.position, Time.deltaTime * speedPower);
                if (demonBallCopy.transform.position == waypointsPower[1].transform.position)
                {
                    
                    objVisible = false;
                    Destroy(demonBallCopy);
                    randomNb = 0;
                    frames = 0;
                }
            }
            return;
        }
        else
        {
            frames = frames + 1;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.Contains("Arrow"))
        {
            DemonHit();
        }
    }

    private void DemonHit()
    {

        audio = GetComponent<AudioSource>();
        demonLife = demonLife - 1;

        if (demonLife == 0)
        {
            animator = GetComponent<Animator>();
            animator.SetBool("dead", true);
            audio.clip = demonDeadSound;
            audio.volume = 0.75f;
            audio.Play();
            GameVariables.nbDemons--;
            Destroy(gameObject, 5f);
            if (GameVariables.nbDemons == 0)
            {
                timeStop = Time.time - timeStart;
                GameVariables.time = GameVariables.time + timeStop;
                TimeCount.saveTime();
                Invoke("ChangeLevel", 3.0f);
            }
            return;

        }

        audio.Play();

    }

    void ChangeLevel()
    {
        Application.LoadLevel(6);
    }

    void onAttack()
    {
        demonBallCopy = Instantiate(demonBall, waypointsPower[0].transform.position, Quaternion.identity);

        isCopied = true;
    }

    


}
