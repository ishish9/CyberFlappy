using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardForce : MonoBehaviour
{
    private Rigidbody rigid;
    private float r_speed = 250f;
    public float speed;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //Move Forward
        {
            rigid.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        //Rotate
        {
            transform.Rotate(0f, r_speed * Time.deltaTime, 0f, Space.Self);
        }
       /* if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(0, 5, 0, ForceMode.Impulse);
        }
       */
    }
}
