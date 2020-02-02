using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGameScript : MonoBehaviour
{
    public Button exitButton;
    void Start()
    {
        Button btn = exitButton.GetComponent<Button>();
        exitButton.onClick.AddListener(ExitGame);
    }


    void ExitGame() 
    {
        Debug.Log("exit game");
        Application.Quit();
    }
}
