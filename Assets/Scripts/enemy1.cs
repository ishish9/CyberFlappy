using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public coinLogic script1;
    public GameObject playerball;
    public Rigidbody rplayerball;
    public AudioSource deathfx;
    public Transform ballfallresetfx;
    public Transform ball;
    public ParticleSystem ballfallpart;
    public GameObject score_stuff;
    public GameObject restart;
    public GameObject jumping;
    public Transform Trestart;
    public Transform Trestart_location;

    void Update()
    {
        transform.Rotate(0f, -300f * Time.deltaTime, 0f, Space.Self);
    }

    void OnTriggerEnter()
    {
            rplayerball = rplayerball.GetComponent<Rigidbody>();
            script1.AdCount = script1.AdCount + 1;
            playerball.SetActive(false);
            rplayerball.constraints = RigidbodyConstraints.FreezeAll;
            deathfx.Play();
            ballfallresetfx.position = ball.position;
            ballfallpart.Play();

            StartCoroutine(ExampleCoroutine());

            IEnumerator ExampleCoroutine()
            {
                yield return new WaitForSeconds(2);

                score_stuff.SetActive(true);
                restart.SetActive(true);
                jumping.SetActive(false);
                Trestart.position = Trestart_location.position;
            }
    }
}
