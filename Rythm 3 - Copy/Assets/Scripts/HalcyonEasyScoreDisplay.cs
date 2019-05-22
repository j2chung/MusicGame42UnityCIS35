using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HalcyonEasyScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("HalcyonEasy Current Score") >= PlayerPrefs.GetInt("HalcyonEasy High Score"))
        {
            PlayerPrefs.SetInt("HalcyonEasy High Score", PlayerPrefs.GetInt("HalcyonEasy Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("HalcyonEasy High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("HalcyonEasy Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("HalcyonEasy Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("HalcyonEasy Max Combo").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

