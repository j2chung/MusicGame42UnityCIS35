using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void Load()
    {

        string scene = PlayerPrefs.GetString("Current") + "Hard";
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }

    public void LoadEasy()
    {

        string scene = PlayerPrefs.GetString("Current") + "Easy";
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
