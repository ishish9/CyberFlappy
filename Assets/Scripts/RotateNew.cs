using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNew : MonoBehaviour {

    private float speedd = 50f;

    void Update()
    {
        transform.Rotate(speedd * Time.deltaTime, 0f, 0f, Space.Self);
    }
}