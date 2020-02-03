using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevHoursBarScript : MonoBehaviour
{
    public Image devHoursBar;
    private static float totalDevHoursLeft = 1000;
    void Update()
    {
        devHoursBar.rectTransform.sizeDelta = new Vector2(totalDevHoursLeft, 128);
        Debug.LogError(totalDevHoursLeft);
    }

}
