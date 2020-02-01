using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    public Button startButton;
    public int number;
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);

    }

    void StartGame()
    {
        Debug.Log("Clicked Start");
        GameMasterScript.start_game = true;
        
    }

}
