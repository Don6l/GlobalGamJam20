using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButtonScript : MonoBehaviour
{
    public Button nextButton;
    public Text introText;

    void Start()
    {
        Button btn = nextButton.GetComponent<Button>();
        nextButton.onClick.AddListener(NextSection);
    }

    void NextSection()
    {
        Debug.Log("Next Section");
        introText.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
    }
}
