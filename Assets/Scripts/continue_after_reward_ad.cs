using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continue_after_reward_ad : MonoBehaviour
{
    public coinLogic script;
    public Rigidbody ballrigid;
    public GameObject restart;
    public GameObject score_stuff;
    public GameObject ballobj;
    public Transform balltrans;
    public Transform spawn_effects;
    public AudioSource level_respawn_sound;
    public ParticleSystem pspawn_effects;
    public Transform continue_after_reward;
    public Transform location;
    public GameObject jumping;
    public GameObject Highscore_title;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject self;
    [SerializeField] private Transform spawnsave1;
    [SerializeField] private Transform spawnsave2;
    [SerializeField] private Transform spawnsave3;
    [SerializeField] private Transform spawnsave4;
    [SerializeField] private Transform spawnsave5;

    public void StartReward()
    {
        //script.scorevariable = script.scoresaveforsavepoint;
        script.pointCountUpdate();
        ballrigid = ballrigid.GetComponent<Rigidbody>();
       // script.NoContinue = script.buttonset;
        switch (script.buttonset)
        { 
            case 1:
            balltrans.position = spawnsave1.position;
            break;

            case 2:
            balltrans.position = spawnsave2.position;
            break;

            case 3:
            balltrans.position = spawnsave3.position;
            break;

            case 4:
            balltrans.position = spawnsave4.position;
            break;

            case 5:
            balltrans.position = spawnsave5.position;
            break;
        }

        restart.SetActive(false);
        ballrigid.isKinematic = true;
        score_stuff.SetActive(false);
        ballobj.SetActive(true);
        spawn_effects.position = balltrans.position;
        level_respawn_sound.Play();
        pspawn_effects.Play();
        continue_after_reward.position = location.position;
        script.save_position = "Spawn Save 1";

        StartCoroutine(wait());

        IEnumerator wait()
        {
            yield return new WaitForSeconds(2);

            ballrigid.isKinematic = false;
            jumping.SetActive(true);
            Highscore_title.SetActive(false);

            for (int j = 0; j < parentTransform.childCount; j++)
            {
                parentTransform.GetChild(j).gameObject.SetActive(true);
            }
            self.SetActive(false);
        }

    }

  
}
