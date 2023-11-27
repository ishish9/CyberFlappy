using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    [SerializeField] private Rigidbody r;
    [SerializeField] private Transform restart;
    [SerializeField] private Transform location;
    [SerializeField] private Transform playerball;
    [SerializeField] private Transform spawntitle;
    [SerializeField] private coinLogic script;
    [SerializeField] private GameObject start2;

    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        r = r.GetComponent<Rigidbody>();
        restart.position = location.position;
        playerball.position = spawntitle.position;
        r.isKinematic = true;
        script.highscore = PlayerPrefs.GetInt("savedScore");

        if (PlayerPrefs.GetInt("doublespeed") == 1)
        {
            start2.SetActive(true);
        }
    }
}
