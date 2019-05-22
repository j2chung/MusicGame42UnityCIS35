using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaikaEasyRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void ResetScene()
    {
        SceneManager.LoadScene("SaikaEasy");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
