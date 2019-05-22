using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {
    public AudioSource audio;

    void Start()
    {
        
    }
    public void Pause()
    {
        Time.timeScale = 0;
        audio.Pause();
    }

    public void Resume()
    {
        Time.timeScale = 1;
        audio.UnPause();
    }

}
