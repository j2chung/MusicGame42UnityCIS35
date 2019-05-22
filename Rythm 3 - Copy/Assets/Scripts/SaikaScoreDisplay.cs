using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaikaScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("Saika Current Score") >= PlayerPrefs.GetInt("Saika High Score"))
        {
            PlayerPrefs.SetInt("Saika High Score", PlayerPrefs.GetInt("Saika Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("Saika High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("Saika Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("Saika Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("Saika Max Combo").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

