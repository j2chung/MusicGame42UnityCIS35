using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("Current Score") >= PlayerPrefs.GetInt("High Score"))
        {
            PlayerPrefs.SetInt("High Score", PlayerPrefs.GetInt("Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("Max Combo").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
