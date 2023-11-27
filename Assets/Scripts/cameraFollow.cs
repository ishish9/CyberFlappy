using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform cam;    

    private void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x + 0f, 20f, player.transform.position.z + -25f);
    }
}
