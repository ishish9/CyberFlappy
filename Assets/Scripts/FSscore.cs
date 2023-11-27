using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSscore : MonoBehaviour
{
    public Text FS;

    void Update()
    {
        FS.text = PlayerPrefs.GetInt("HighFinalScore").ToString();
    }
}
