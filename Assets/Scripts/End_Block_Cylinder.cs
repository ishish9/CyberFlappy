using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Block_Cylinder : MonoBehaviour
{
    public coinLogic script;
    public GameObject doublespeedunlocked;
    public Rigidbody rigid;
    public AudioSource winjingle;
    public AudioSource music;
    public ParticleSystem end_particle_effects;
    public GameObject jumping;
    public Transform ball;
    public Transform spawn_ending;
    public GameObject score_stuff_FINAL;
    public GameObject Fireworks_1;
    public GameObject Fireworks_2;
    public GameObject Fireworks_3;
    public GameObject Fireworks_4;
    public GameObject Main_Camera;
    public GameObject Ending_Camera;
    public GameObject Coin_Image;
    public GameObject Count_Text;

    private void Update()
    {
        transform.Rotate(0f, 200f * Time.deltaTime, 0f, Space.Self);
    }

    void OnTriggerEnter()
    {
        if(PlayerPrefs.GetInt("doublespeed") == 0)
        {
            doublespeedunlocked.SetActive(true);
        }else{
            doublespeedunlocked.SetActive(false);
        }
        PlayerPrefs.SetInt("doublespeed", 1);
        PlayerPrefs.Save();
        rigid = rigid.GetComponent<Rigidbody>();
        rigid.constraints = RigidbodyConstraints.FreezeAll;
        winjingle.Play();
        end_particle_effects.Play();
        jumping.SetActive(false);
        ball.position = spawn_ending.position;
        music.Stop();

        StartCoroutine(cool());

        IEnumerator cool()
        {
            yield return new WaitForSeconds(6);
            music.Play();
            score_stuff_FINAL.SetActive(true);
            Fireworks_1.SetActive(true);
            Fireworks_2.SetActive(true);
            Fireworks_3.SetActive(true);
            Fireworks_4.SetActive(true);
            Main_Camera.SetActive(false);
            Ending_Camera.SetActive(true);
            Coin_Image.SetActive(false);
            Count_Text.SetActive(false);
            if(script.scorevariable > PlayerPrefs.GetInt("HighFinalScore"))
            {
                PlayerPrefs.SetInt("HighFinalScore", script.scorevariable);
                PlayerPrefs.Save();
            }

        }


    }


}
