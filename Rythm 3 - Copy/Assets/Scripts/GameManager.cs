using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    /** to do list
     * different song (its too fast!)
     * cleaner ui stuff
     * menu
     * maybe pause
     * score screen
     * art stuff
     */
    public int score;
    public int baseCombo;
    public int combo;
    public int comboScore;
    public int maxCombo;
    public int tracker;
    public int notesHit;
    public Text scoreText;
    public Text comboText;
    public Text hitText;
    public static GameManager instance;
    private List<Color32> color32;

	// Use this for initialization
	void Start () {
        tracker = 1;
        comboScore = 0;
        maxCombo = 0;
        baseCombo = 1;
        combo = 0;
        score = 0;
        notesHit = 0;
        instance = this;
        color32 = new List<Color32>();
        color32.Add(new Color32(255, 0, 0, 255));
        color32.Add(new Color32(255, 128, 0, 255));
        color32.Add(new Color32(255, 255, 51, 255));
        color32.Add(new Color32(153, 255, 51, 255));
        color32.Add(new Color32(51, 255, 51, 255));
        color32.Add(new Color32(51, 255, 153, 255));
        color32.Add(new Color32(51, 255, 255, 255));
        color32.Add(new Color32(102, 178, 255, 255));
        color32.Add(new Color32(51, 51, 255, 255));
        color32.Add(new Color32(153, 51, 255, 255));
        color32.Add(new Color32(255, 51, 255, 255));
        color32.Add(new Color32(255, 51, 153, 255));

    }
	
	// Update is called once per frame
	void Update () {

	}

    //@param int hitType 1 = perfect, 2 = good, 3 = ok
    //perfect = 6x, good = 5x, ok = 4x x = 110;
    //combo = (0.1) * (1000000) / 546 about 183
    public void NoteHit(int hitType, int noteNumber)
    {
        notesHit++;
        if (combo > maxCombo)
        {
            maxCombo = combo;
        }
        if (noteNumber - baseCombo == combo)
        {
            combo++;
            score += 183;
        }
        else
        {
            baseCombo = noteNumber + 1;
            combo = 0;
        }

        score += 10 * 238;
        scoreText.text = score.ToString();
        comboText.text = "COMBO: " + combo;
        hitText.text = "PERFECT";
        hitText.color = color32[Random.Range(0, color32.Count - 1)];
    }

    //note was a bad note 
    public void NoteBad()
    {
        hitText.text = "MISS";
        hitText.color = color32[Random.Range(0, color32.Count - 1)];
        comboText.text = "COMBO: 0";
    }
}
