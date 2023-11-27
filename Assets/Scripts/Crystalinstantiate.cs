using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystalinstantiate : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform crystalSpawn;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, 0f);
    [SerializeField] private AudioSource au;
    [SerializeField] private ParticleSystem explode;
    [SerializeField] private ParticleSystem plus1;
    [SerializeField] private Transform explodep;
    [SerializeField] private Transform plus1p;
    [SerializeField] private coinLogic script;

    public void OnTriggerEnter()
    {
        //Instantiate(prefab, crystalSpawn.transform.position + offset, prefab.transform.rotation);
        prefab.transform.position = crystalSpawn.transform.position + offset;
        prefab.SetActive(true);
    }

    /*public void cystalcollision()
    {
        au.Play();
        explodep.position = transform.position;
        explode.Play();
        plus1p.position = transform.position;
        plus1.Play();
        script.scorevariable = script.scorevariable += 25;
        script.pointCountUpdate();
    }*/
}
