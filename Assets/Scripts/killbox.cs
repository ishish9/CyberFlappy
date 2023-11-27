using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour
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

            restart.SetActive(true);
            score_stuff.SetActive(true);
            jumping.SetActive(false);
            Trestart.position = Trestart_location.position;
        }
    }
}
