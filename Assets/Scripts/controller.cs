using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rigid.AddForce(-Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") > 0)
        { 
            rigid.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(-Vector3.forward * speed * Time.deltaTime);

        }
    }

}
