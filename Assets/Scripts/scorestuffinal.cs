using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorestuffinal : MonoBehaviour
{
    public coinLogic script;
    public Text score;
    public GameObject self;

    void Update()
    {
       if (script.scorevariable > script.highscore)
        {
            score.text = script.scorevariable.ToString();
            self.SetActive(true);
            script.highscore = script.scorevariable;
            PlayerPrefs.SetInt("savedScore", script.highscore);
            PlayerPrefs.Save();
        }
        else
        {
            score.text = script.scorevariable.ToString();
        }
    }
}
