using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_destroy_crystal : MonoBehaviour
{
    [SerializeField] private AudioSource au;
    [SerializeField] private ParticleSystem explode;
    [SerializeField] private ParticleSystem plus1;
    [SerializeField] private Transform explodep;
    [SerializeField] private Transform plus1p;
    [SerializeField] private coinLogic script;
    [SerializeField] private Rigidbody rigid;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, -200f * Time.deltaTime, Space.World);
        rigid.velocity = new Vector3(-5, 0, 0);
    }

    void OnTriggerEnter()
    {
        au.Play();
        explodep.position = transform.position;
        explode.Play();
        plus1p.position = transform.position;
        plus1.Play();
        script.scorevariable = script.scorevariable += 25;
        script.pointCountUpdate();
        gameObject.SetActive(false);   
    }

}
