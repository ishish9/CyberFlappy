using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_projectile : MonoBehaviour
{
    //[SerializeField] private AfterDeathWait script;
    private float force = 20f;
    private GameObject player;
    private Rigidbody rb;
    public static bool isDead = false;

    void Start()
    {
        Destroy(gameObject, 2f);
        if (isDead == true)
        {
            Destroy(gameObject);
        }
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
    }

    void Update()
    {
        transform.Rotate(0f, 0f, 200f * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter(Collider other)
    {  
        if (other.gameObject.CompareTag("Player"))
        {
            isDead = true;
            Destroy(gameObject);    
        }
    }
}
