using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksLaunch : MonoBehaviour
{
    [SerializeField] private ParticleSystem p1;
    [SerializeField] private ParticleSystem p2;
    [SerializeField] private AudioSource Fireworks_Launch;
    [SerializeField] private AudioSource Fireworks_Explode;
    [SerializeField] private AudioSource Fireworks_Fizz;
    private bool LaunchBool = true;
    private bool ExplodeBool = false;
    private bool FizzBool = false;

    private void Update()
    {
        var launch = p1.particleCount;
        var explode = p2.particleCount;

        if (launch == 1 && LaunchBool == true)
        {
            Fireworks_Launch.Play();
            LaunchBool = false;
            ExplodeBool = true;
        }

        if (launch == 0 && ExplodeBool == true)
        {
            Fireworks_Explode.Play();
            ExplodeBool = false;
            FizzBool = true;
        }

        if (explode == 0 && FizzBool == true)
        {
            Fireworks_Fizz.Play();
            FizzBool = false;
            LaunchBool = true;
        }
    }
}
