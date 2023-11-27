using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face40 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigid;
    private float speed = 5;

    void Update()
    {
        rigid = rigid.GetComponent<Rigidbody>();
        rigid.AddForce(-Vector3.up * speed);
    }
}
