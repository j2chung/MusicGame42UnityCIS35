using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindings : MonoBehaviour {

    private List<string> keys;
    public List<Dropdown> dropDown = new List<Dropdown>();
	// Use this for initialization
	void Start () {
        keys = new List<string>
        { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J",
        "K", "L", "Z", "X", "C", "V", "B", "N", "M"};
        for(int i = 0; i < dropDown.Count; i++)
        {
            dropDown[i].AddOptions(keys);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
