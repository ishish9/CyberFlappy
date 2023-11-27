using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_NO_destroy : MonoBehaviour
{
    public AudioSource au;
    public ParticleSystem explode;
    public ParticleSystem plus1;
    public Transform explodep;
    public Transform plus1p;
    public coinLogic script;

    private void OnTriggerEnter()
    {
        au.Play();
        explodep.position = transform.position;
        explode.Play();
        plus1p.position = transform.position;
        plus1.Play();
        script.scorevariable++;
        script.pointCountUpdate();
    }
}
