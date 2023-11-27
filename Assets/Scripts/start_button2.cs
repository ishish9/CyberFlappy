using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_button2 : MonoBehaviour
{
    [SerializeField] private Rigidbody ball;
    [SerializeField] private Transform start2;
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
    [SerializeField] private GameObject D_start;
    [SerializeField] private GameObject D_menuparticleeffects;
    [SerializeField] private GameObject D_Title;
    [SerializeField] private GameObject D_Title_Camera;
    [SerializeField] private GameObject D_start2;
    [SerializeField] private ParticleSystem spawneffect;
    [SerializeField] private AudioSource respawnsnd;
    [SerializeField] private AudioSource music;
    [SerializeField] private forwardForce script;


    public void OnButtonClick()
    {
        Physics.gravity = new Vector3(0, -110, 0);
        script.speed = 160f;
        ball = ball.GetComponent<Rigidbody>();
        coin_image.SetActive(true);
        count_text.SetActive(true);
        mainCamera.SetActive(true);
        showHighScore.SetActive(false);
        TrphieParticle.SetActive(false);
        Destroy(D_platform);
        Destroy(D_start);
        Destroy(D_menuparticleeffects);
        Destroy(D_Title);
        Destroy(D_Title_Camera);
        start2.position = location.position;
        tball.position = spawnStart.position;
        spawnEffects.position = tball.position;
        respawnsnd.Play();
        spawneffect.Play();
            
        StartCoroutine(ExampleCoroutine());
        
        IEnumerator ExampleCoroutine()
        {
            yield return new WaitForSeconds(2);
            
            jumping.SetActive(true);
            ball.isKinematic = false;
            music.Play();
            Destroy(D_start2, 1);
        }     
    }
}
