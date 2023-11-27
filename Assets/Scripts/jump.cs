using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    [SerializeField] private AudioSource Jumpsnd;
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private Button jumpbtn; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpbtn.interactable = false;
            rigid.isKinematic = false;
            rigid.constraints = RigidbodyConstraints.None;
            rigid.AddForce(0, 5, 0, ForceMode.Impulse);
            Jumpsnd.Play();
        }
    }

    public void Jump()
    { 
        {
            rigid.isKinematic = false;
            rigid.constraints = RigidbodyConstraints.None;
            rigid.AddForce(0, 5, 0, ForceMode.Impulse);
            Jumpsnd.Play();
        }
    }
}
