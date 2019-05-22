using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class PlayClick : MonoBehaviour, IPointerDownHandler {
    public GameObject track;

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        Debug.Log("hello");
    }


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
