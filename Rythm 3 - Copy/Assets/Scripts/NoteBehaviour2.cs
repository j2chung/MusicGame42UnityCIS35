using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class NoteBehaviour2 : MonoBehaviour
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

    // Use this for initialization
    void Start()
    {
        transform.name = GameManager.instance.tracker.ToString();
        GameManager.instance.tracker++;
        bpm = bpm / 60f;
        main = GameObject.Find("NoteEvent");
        right = GameObject.Find("Right");
        fRight = GameObject.Find("Far_Right");
        center = GameObject.Find("Center");
        left = GameObject.Find("Left");
        fLeft = GameObject.Find("Far_Left");
        if (main != null)
        {
            mainScript = main.GetComponent<NewBehaviourScript>();
            index2 = mainScript.index;
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
            keyToPress = KeyCode.Space;
        }
        else if (mainScript.noteList[index2].getNoteToPress().Equals("B"))
        {
            endX = 100f;
        }
        else
        {
            endX = 9000;
        }
        //startpos = new Vector2()
    }

    // Update is called once per frame
    void Update()
    {
        //move notes down linear interpolation
        transform.position = Vector3.Lerp(
        new Vector3(endX, 180f, 7f),
        new Vector3(endX, -9f, 7f),
        (8 - (mainScript.noteBeatList[index2] - mainScript.songpositionbeats)) / 8);

        //destroy self
        if (transform.position.y <= -9.5f)
        {
            //Object.Destroy(this.gameObject);
            //gameObject.SetActive(false);
        }

        //button press stuff
        if (transform.position.y < -5f && transform.position.y > -10f)
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
                gameObject.SetActive(false);
                hitpos = transform.position.y;
                if (hitpos >= -10f && hitpos < -6f)
                {
                    Debug.Log("perfect: " + hitpos);
                    GameManager.instance.NoteHit(1, Convert.ToInt32(transform.name));
                }
                else if (hitpos >= -6f && hitpos < -5.5f)
                {
                    Debug.Log("good: " + hitpos);
                    GameManager.instance.NoteHit(2, Convert.ToInt32(transform.name));
                }
                else if (hitpos >= -5.5f && hitpos < -5f)
                {
                    Debug.Log("ok: " + hitpos);
                    GameManager.instance.NoteHit(3, Convert.ToInt32(transform.name));
                }
                else if (hitpos >= -5f && hitpos < -5f)
                {
                    Debug.Log("bad: " + hitpos);
                    GameManager.instance.NoteBad();
                }
            }
        }
    }
}

