using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HKEasyScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("HKE Current Score") >= PlayerPrefs.GetInt("HKE High Score"))
        {
            PlayerPrefs.SetInt("HKE High Score", PlayerPrefs.GetInt("HKE Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("HK High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("HKE Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("HKE Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("HKE Max Combo").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

