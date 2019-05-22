using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour {

    public Button click;
    private void Start()
    {
        Button btn = click.GetComponent<Button>();
        btn.onClick.AddListener(clickExit);
    }

    public static void clickExit() => Application.Quit();
}
