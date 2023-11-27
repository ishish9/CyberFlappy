using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFace : MonoBehaviour
{
    public GameObject Human_face_male_strong_40;

    void OnTriggerEnter()
    {
        Destroy(Human_face_male_strong_40, 7f);
        Destroy(gameObject, 8f);
    }

    
}
