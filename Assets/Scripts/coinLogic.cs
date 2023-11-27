using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinLogic : MonoBehaviour
{
    public string save_position = "Spawn Start";
    public int AdCount = 0;
    public int highscore = 0;
    public int buttonset = 0;
    public int scorevariable = 0;
    public int scoresaveforsavepoint = 0;
    public int NoContinue = 0;
    public int hearts = 3;
    public bool haveReward = false;
    public GameObject count_text;
    public int ButtonTemp;

    public int SaveScoreReward1;
    public int SaveScoreReward2;
    public int SaveScoreReward3;
    public int SaveScoreReward4;
    public int SaveScoreReward5;

    public void pointCountUpdate()
    {
        count_text.GetComponent<Text>().text = scorevariable.ToString();
    }

    public void youHaveReward()
    {
        haveReward = true;
    }
}