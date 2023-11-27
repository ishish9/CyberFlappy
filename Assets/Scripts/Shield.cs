using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private Transform ball;
    private float r_speed = 250f;


    void Update()
    {
        transform.position = ball.position;
        transform.Rotate(0f, 0f, r_speed * Time.deltaTime, Space.Self);
    }
}
