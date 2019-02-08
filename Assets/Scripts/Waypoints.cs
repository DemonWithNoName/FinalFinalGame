using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    private Animator animator;

    // Update is called once per frame
    void Update() {
        animator = GetComponent<Animator>();
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Walk") { 
            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                transform.Rotate(Vector3.up * 180);
                if (current >= waypoints.Length)
                {
                    current = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        }
		
	}
}
