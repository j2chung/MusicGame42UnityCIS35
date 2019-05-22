using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaikaHardScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public Text comboText;
    public Text noteHits;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("SaikaH Current Score") >= PlayerPrefs.GetInt("SaikaH High Score"))
        {
            PlayerPrefs.SetInt("SaikaH High Score", PlayerPrefs.GetInt("SaikaH Current Score"));
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("SaikaH High Score").ToString();
        scoreText.text = "Score : " + PlayerPrefs.GetInt("SaikaH Current Score").ToString();
        noteHits.text = "Notes Hit : " + PlayerPrefs.GetInt("SaikaH Notes Hit").ToString();
        comboText.text = "Max Combo : " + PlayerPrefs.GetInt("SaikaH Max Combo").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}