using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour
{
    public static bool start_game = false;
    // Start is called before the first frame update
    void Start()
    {
        start_game = false;
        Debug.Log(start_game);
    }

    // Update is called once per frame
    void Update()
    {
        if (!start_game)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
