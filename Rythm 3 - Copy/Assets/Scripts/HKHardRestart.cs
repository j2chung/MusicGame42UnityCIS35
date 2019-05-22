using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HKHardRestart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public void ResetScene()
    {
        SceneManager.LoadScene("HKHard");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
