using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSscore : MonoBehaviour
{
    public Text HS;

    void Update()
    {
        HS.text = PlayerPrefs.GetInt("savedScore").ToString();
    }
}
