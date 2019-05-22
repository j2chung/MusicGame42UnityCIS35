using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {
    private List<Color32> color32;
    public Text text;
	// Use this for initialization
	void Start () {
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
        text.color = color32[Random.Range(0, color32.Count - 1)];
    }
}
