using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score2 : MonoBehaviour
{
    public coinLogic script1;
    public InitializeAds script2;
    public Text scores;
    public GameObject highscore_title;
    public GameObject reward_save;
    public GameObject restart;
    private bool LoadAdOnce = true;

    public void Update()
    {
        if (script1.AdCount == 4 && LoadAdOnce == true)
            {
                LoadAdOnce = false;
                script2.LoadInterstitialAd();
            }

        //If Statement Start//
        if (script1.scorevariable > script1.highscore)
        {
            if (script1.buttonset >= 1)
            {
                scores.text = script1.scorevariable.ToString();
                highscore_title.SetActive(true);
                script1.highscore = script1.scorevariable;
                PlayerPrefs.SetInt("savedScore", script1.highscore);
                PlayerPrefs.Save();

                if (script1.AdCount >= 5)
                    {
                        script1.AdCount = 0;
                            if(!reward_save.activeSelf)
                            {
                                restart.SetActive(false);
                                script2.ShowInterstitial();
                                LoadAdOnce = true;
                            }
                            else 
                            {
                               // restart.SetActive(false);
                                LoadAdOnce = true;
                            }
                    }
            }
            else
            {
                scores.text = script1.scorevariable.ToString();
                highscore_title.SetActive(true);
                script1.highscore = script1.scorevariable;
                PlayerPrefs.SetInt("savedScore", script1.highscore);
                if (script1.AdCount >= 5)
                {
                    script1.AdCount = 0;
                        if(!reward_save.activeSelf)
                        {
                            restart.SetActive(false);
                            script2.ShowInterstitial();
                            LoadAdOnce = true;
                        }
                        else
                        {
                           // restart.SetActive(false);
                            LoadAdOnce = true;
                        }
                }

            }
        }
        //ELSE Starts//
        else 
        {
            if (script1.buttonset == 1)
            {
                scores.text = script1.scorevariable.ToString();
                if (script1.AdCount >= 5)
                {
                    script1.AdCount = 0;
                    if (!reward_save.activeSelf)
                    {
                        restart.SetActive(false);
                        script2.ShowInterstitial();
                        LoadAdOnce = true;
                    }
                    else
                    {
                        //restart.SetActive(false);
                        LoadAdOnce = true;
                    }
                }
            }
            else
            {
                scores.text = script1.scorevariable.ToString();
                if (script1.AdCount >= 5)
                {
                        script1.AdCount = 0;
                   if (!reward_save.activeSelf)
                   {
                        restart.SetActive(false);
                        script2.ShowInterstitial();
                        LoadAdOnce = true;
                   }
                   else
                   {
                       // restart.SetActive(false);
                        LoadAdOnce = true;
                   }
                }
            }
        }    
    }        
}
