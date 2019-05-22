using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class NoteBehaviour3 : MonoBehaviour
{
    public float bpm;
    NewBehaviourScript mainScript;
    GameObject main;
    GameObject fRight;
    GameObject right;
    GameObject center;
    GameObject left;
    GameObject fLeft;
    private KeyCode keyToPress;
    int index2;
    float dsptimesong;
    Vector2 startpos;
    Vector2 end;
    public float endX;
    public bool canBePressed;
    private float hitpos;
    private float hitTime;
    private float audioTime;
    public float deltaTime;
    private float prevTime;

    // Use this for initialization
    void Start()
    {
        prevTime = 0f;
        deltaTime = 0.1f;
        transform.name = GameManager.instance.tracker.ToString();
        GameManager.instance.tracker++;
        bpm = bpm / 60f;
        main = GameObject.Find("NoteEvent");
        right = GameObject.Find("Right");
        fRight = GameObject.Find("Far_Right");
        center = GameObject.Find("Center");
        left = GameObject.Find("Left");
        fLeft = GameObject.Find("Far_Left");
        audioTime = 0;
        if (main != null)
        {
            mainScript = main.GetComponent<NewBehaviourScript>();
            index2 = mainScript.index;
            hitTime = mainScript.noteList[index2].getNoteTime();
        }
        if (mainScript.noteList[index2].getNoteToPress().Equals("C"))
        {
            endX = fRight.transform.position.x;
            keyToPress = KeyCode.Semicolon;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("D"))
        {
            endX = right.transform.position.x;
            keyToPress = KeyCode.L;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("E"))
        {
            endX = center.transform.position.x;
            keyToPress = KeyCode.K;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("F"))
        {
            endX = left.transform.position.x;
            keyToPress = KeyCode.J;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("G"))
        {
            endX = fLeft.transform.position.x;
            keyToPress = KeyCode.H;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("B"))
        {
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //startpos = new Vector2()
    }

    // Update is called once per frame
    void Update()
    {
        audioTime = mainScript.songposition;
        deltaTime = audioTime - hitTime;
        //move notes down linear interpolation
        if (Time.timeScale == 1)
        {
            transform.position = Vector3.Lerp(
            new Vector3(endX, 180f, 7f),
            new Vector3(endX, -9f, 7f),
            (8 - (mainScript.noteBeatList[index2] - mainScript.songpositionbeats)) / 8);
        }

        //destroy self
        if (audioTime - .1 > hitTime)
        {
            GameManager.instance.NoteBad();
            Destroy(this.gameObject);
            //gameObject.SetActive(false);
        }

        //button press stuff
        if (deltaTime > -.1f)
        {
            canBePressed = true;
        }
        else
        {
            canBePressed = false;
        }

        //button press stuff
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed == true)
            {
                hitpos = transform.position.y;
                if (deltaTime > -.05f)
                {
                    GameManager.instance.NoteHit(1, Convert.ToInt32(transform.name));
                }
                else if (deltaTime > -0.05f && deltaTime < -.1f)
                {
                    GameManager.instance.NoteBad();
                }
                //GameManager.instance.NoteBad();
                Destroy(this.gameObject);
                //gameObject.SetActive(false);
            }
        }
    }
}

