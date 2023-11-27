using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_button : MonoBehaviour
{
    [SerializeField] private Rigidbody ball;
    [SerializeField] private Transform start;
    [SerializeField] private Transform location;
    [SerializeField] private Transform tball;
    [SerializeField] private Transform spawnStart;
    [SerializeField] private Transform spawnEffects;
    [SerializeField] private GameObject coin_image;
    [SerializeField] private GameObject count_text;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject showHighScore;
    [SerializeField] private GameObject TrphieParticle;
    [SerializeField] private GameObject jumping;
    [SerializeField] private GameObject D_platform;
    [SerializeField] private GameObject D_start2;
    [SerializeField] private GameObject D_menuparticleeffects;
    [SerializeField] private GameObject D_Title;
    [SerializeField] private GameObject D_Title_Camera;
    [SerializeField] private GameObject D_start;
    [SerializeField] private ParticleSystem spawneffect;
    [SerializeField] private AudioSource respawnsnd;
    [SerializeField] private AudioSource music;
    [SerializeField] private forwardForce script;
    [SerializeField] public bool setGravity = false;

    //Easy Mode Specific Stuff
    [SerializeField] private GameObject trigger1;
    [SerializeField] private GameObject trigger2;
    [SerializeField] private GameObject trigger3;
    [SerializeField] private GameObject trigger4;
    [SerializeField] private GameObject trigger5;
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;
    [SerializeField] private GameObject enemy4;
    [SerializeField] private GameObject enemy5;


    public void StartClick()
    {
        if (setGravity == true)
        {
            script.speed = 70f;
            Physics.gravity = new Vector3(0, -70, 0);
            Destroy(trigger1);
            Destroy(trigger2);
            Destroy(trigger3);
            Destroy(trigger4);
            Destroy(trigger5);
            Destroy(enemy1);
            Destroy(enemy2);
            Destroy(enemy3);
            Destroy(enemy4);
            Destroy(enemy5);
        }

        ball = ball.GetComponent<Rigidbody>();
        coin_image.SetActive(true);
        count_text.SetActive(true);
        mainCamera.SetActive(true);
        showHighScore.SetActive(false);
        TrphieParticle.SetActive(false);
        Destroy(D_platform);
        Destroy(D_start);
        Destroy(D_start2);
        Destroy(D_menuparticleeffects);
        Destroy(D_Title);
        Destroy(D_Title_Camera);
        start.position = location.position;
        tball.position = spawnStart.position;
        spawnEffects.position = tball.position;
        respawnsnd.Play();
        spawneffect.Play();
            
        StartCoroutine(w1());
        
        IEnumerator w1()
        { 
            yield return new WaitForSeconds(2);
            
            jumping.SetActive(true);
            ball.isKinematic = false;
            music.Play();
        }
    }
}
