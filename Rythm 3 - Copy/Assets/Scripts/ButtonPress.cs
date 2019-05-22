using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    public KeyCode keyPress;
    public AudioSource audio;
    public AudioClip audioC;
    public SpriteRenderer SR;
    public Sprite spriteUp;
    public Sprite spriteDown;

    // Use this for initialization
    void Start()
    {
        SR.GetComponent<SpriteRenderer>();
        audio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() { 
        if (Input.GetKeyDown(keyPress))
        {
            SR.sprite = spriteDown;
            audio.PlayOneShot(audioC);
        }
        if (Input.GetKeyUp(keyPress))
        {
            SR.sprite = spriteUp;
        }
    }
}