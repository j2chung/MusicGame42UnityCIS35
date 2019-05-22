using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehaviour : MonoBehaviour {
    public float bpm;
    NewBehaviourScript mainScript;
    GameObject main;
    int index2;
    float dsptimesong;
    Vector2 startpos;
    Vector2 end;

	// Use this for initialization
	void Start () {
        bpm = bpm / 30f;
        main = GameObject.Find("MainObj");
        if (main != null)
        {
            mainScript = main.GetComponent<NewBehaviourScript>();
        }
        index2 = mainScript.index;
        //startpos = new Vector2()
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.Lerp(
            new Vector2(0f, 16),
            new Vector2(0f, 0f),
            (8 - (mainScript.noteBeatList[index2] - mainScript.songpositionbeats)) / 8
            );

        /**
        transform.position = Vector2.Lerp(mainScript.noteBeatList[mainScript.index],
            0f,
            8 - (mainScript.noteBeatList[mainScript.index] - mainScript.songpositionbeats2) / 8);
    */
    }
}
