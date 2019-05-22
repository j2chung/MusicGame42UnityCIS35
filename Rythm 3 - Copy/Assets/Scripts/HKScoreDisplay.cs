using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HKScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("HK Current Score") >= PlayerPrefs.GetInt("HK High Score"))
        {
            PlayerPrefs.SetInt("HK High Score", PlayerPrefs.GetInt("HK Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("HK High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("HK Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("HK Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("HK Max Combo").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

