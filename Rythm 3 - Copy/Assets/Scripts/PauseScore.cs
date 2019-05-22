using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScore : MonoBehaviour {

    public Text score;
	// Use this for initialization
	void Start () {
        score.text = GameManager.instance.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
