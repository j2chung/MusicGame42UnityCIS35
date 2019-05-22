using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAudio : MonoBehaviour {
    GameObject temp;
    NewBehaviourScript tempScript;
    AudioSource audio;
    public AudioClip audioC;
    bool switches = false;

	// Use this for initialization
	void Start () {
        temp = GameObject.Find("MainObj");
        audio = GetComponent<AudioSource>();
        if (temp != null)
        {
            tempScript = temp.GetComponent<NewBehaviourScript>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        /**
        if (tempScript.songpositionbeats2 >= 8f && switches == false)
        {
            audio.PlayOneShot(audioC);
            switches = true;
        }
    */
    }
}
