using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    AudioSource audio;
    public float timeLeft = 90.0f;
    public UnityEngine.UI.Text timerText;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        timeLeft -= Time.deltaTime;
        timerText.text = Mathf.Floor(timeLeft/60).ToString("00") + ":" + (timeLeft % 60).ToString("00");

        if(timeLeft <= 0)
        {
            Time.timeScale = 0;
            timerText.text = "Game Over";
            //yield return new WaitForSeconds(5);
            audio = GetComponent<AudioSource>();
            audio.Play();
            //Application.LoadLevel(0);
        }
	}
}
