using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public coinLogic script1;
    public GameObject Title;
    public GameObject start;
    public GameObject starteasy;
    public GameObject Trphie_partilce;
    public GameObject show_high_score;
    public GameObject start2;
    public GameObject Highscore_show;

    public void TrophyBack()
    {
        Title.SetActive(true);
        start.SetActive(true);
        starteasy.SetActive(true);
        Trphie_partilce.SetActive(true);
        show_high_score.SetActive(true);

        if (PlayerPrefs.GetInt("doublespeed") == 0)
        {
            start2.SetActive(false);
            Highscore_show.SetActive(false);
        }
        else 
        {
            start2.SetActive(true);
            Highscore_show.SetActive(false);
        }

    }

   
}
