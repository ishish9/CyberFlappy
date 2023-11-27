using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReward : MonoBehaviour
{
    [SerializeField] private GameObject reward_save;
    [SerializeField] private coinLogic script;
    [SerializeField] private InitializeAds script2;
    [SerializeField] public int buttonsetInt;

    void OnTriggerEnter()
    {
        reward_save.SetActive(true);
        script.ButtonTemp = buttonsetInt;
        //script.buttonset = buttonsetInt;
        script.scoresaveforsavepoint = script.scorevariable;
        script2.LoadRewardedAd();

        switch (buttonsetInt)
        {
            case 1:
                script.SaveScoreReward1 = script.scorevariable;
                break;

            case 2:
                script.SaveScoreReward2 = script.scorevariable;
                break;

            case 3:
                script.SaveScoreReward3 = script.scorevariable;
                break;

            case 4:
                script.SaveScoreReward4 = script.scorevariable;
                break;

            case 5:
                script.SaveScoreReward5 = script.scorevariable;
                break;
        }
    }
}
