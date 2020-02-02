using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    public Button startButton;
    public Text introText;
    public Text titleText;

    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
        
    }

    void StartGame()
    {
        Debug.Log("Clicked Start");
        GameMasterScript.start_game = true;
        startButton.gameObject.SetActive(false);
        introText.gameObject.SetActive(true);
        titleText.gameObject.SetActive(false);
        
    }

}
