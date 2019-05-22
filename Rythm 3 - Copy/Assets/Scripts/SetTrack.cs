using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void HalcyonTrack()
    {
        PlayerPrefs.SetString("Current", "Halcyon");
    }

    public void HKTrack()
    {
        PlayerPrefs.SetString("Current", "HK");
    }

    public void SaikaTrack()
    {
        PlayerPrefs.SetString("Current", "Saika");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
