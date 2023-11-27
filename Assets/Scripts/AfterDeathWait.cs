using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterDeathWait : MonoBehaviour
{
    public GameObject score_stuff;
    public GameObject restart;
    public GameObject jumping;
    public Transform Trestart;
    public Transform Trestart_location;
    public bool easyModeActive = false;

    //On Trigger//
    [SerializeField] private coinLogic script1;
    [SerializeField] private start_button script2;
    [SerializeField] private GameObject playerball;
    [SerializeField] private Rigidbody rplayerball;
    [SerializeField] private AudioSource deathfx;
    [SerializeField] private Transform ballfallresetfx;
    [SerializeField] private Transform ball;
    [SerializeField] private ParticleSystem ballfallpart;
    [SerializeField] private ParticleSystem projectileExplodeParticle;
    [SerializeField] private Transform projectileExplodeTransform;
    [SerializeField] private AudioSource projectileExplodeSound;
    [SerializeField] private GameObject stopscript;
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;



    void Update()// Check for Death
    {
        if (enemy_projectile.isDead == true)
        {
            if (easyModeActive == true)
            {
                enemy_projectile.isDead = false;
                heartManager();
            }
            else
            {
                stopscript.SetActive(false);
                enemy_projectile.isDead = false;
                DeathRestart();
            }
            
        }
        
    }

    public void activateEasyMode()
    {
        easyModeActive = true;
    }

    void heartManager()
    {
        script1.hearts = script1.hearts - 1;
        switch (script1.hearts)
        {
            case -1:
                script1.hearts = 3;
                stopscript.SetActive(false);
                DeathRestart();
                StartCoroutine(w1());

                IEnumerator w1()
                {
                    yield return new WaitForSeconds(2);
                    heart1.SetActive(true);
                    heart2.SetActive(true);
                    heart3.SetActive(true);
                }
                break;
            case 0:
                heart1.SetActive(false);
                break;

            case 1:
                heart2.SetActive(false);
                break;

            case 2:
                heart3.SetActive(false);
                break;

            case 3:
                heart1.SetActive(false);
                break;
        }

    }

    public void DeathRestart()
    {
        rplayerball = rplayerball.GetComponent<Rigidbody>();
        script1.AdCount = script1.AdCount + 1;
        playerball.SetActive(false);
        rplayerball.constraints = RigidbodyConstraints.FreezeAll;
        deathfx.Play();
        ballfallresetfx.position = ball.position;
        ballfallpart.Play();
        projectileExplodeTransform.position = ball.position;
        projectileExplodeParticle.Play();
        projectileExplodeSound.Play();

        StartCoroutine(wait());

        IEnumerator wait()
        {
            yield return new WaitForSeconds(2);

            score_stuff.SetActive(true);
            restart.SetActive(true);
            jumping.SetActive(false);
            Trestart.position = Trestart_location.position;
            stopscript.SetActive(true);

        }
    }

    
}
