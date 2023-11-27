using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    public coinLogic script;
    public continue_after_reward_ad script2;
    public Rigidbody rigid;
    public GameObject score_stuff;
    public GameObject ball;
    public GameObject continue_after_reward_ad;
    public GameObject reward_save;
    public Transform ballt;
    public Transform spawn_effects;
    public AudioSource level_respawn;
    public ParticleSystem spawn_particle;
    public Transform restartt;
    public Transform location;
    public GameObject jumping;
    public GameObject Highscore_title;
    public GameObject restartobj;
    public Transform parentTransform;
    [SerializeField] private Transform spawnstart;
    [SerializeField] private Transform spawnsave1;
    [SerializeField] private Transform spawnsave2;
    [SerializeField] private Transform spawnsave3;
    [SerializeField] private Transform spawnsave4;
    [SerializeField] private Transform spawnsave5;

    public void restartBTN()
    {
       

       
            //script.scorevariable = script.scoresaveforsavepoint;        
            if (script.haveReward == true) 
            {
                switch (script.buttonset)
                {

                case 0:
                    ballt.position = spawnstart.position;
                    script.scorevariable = 0;
                    script.pointCountUpdate();
                    break;
                case 1:
                    ballt.position = spawnsave1.position;
                    script.scorevariable = script.SaveScoreReward1;
                    script.pointCountUpdate();
                    break;

                case 2:
                    ballt.position = spawnsave2.position;
                    script.scorevariable = script.SaveScoreReward2;
                    script.pointCountUpdate();
                    break;

                case 3:
                    ballt.position = spawnsave3.position;
                    script.scorevariable = script.SaveScoreReward3;
                    script.pointCountUpdate();
                    break;

                case 4:
                    ballt.position = spawnsave4.position;
                    script.scorevariable = script.SaveScoreReward4;
                    script.pointCountUpdate();
                    break;

                case 5:
                    ballt.position = spawnsave5.position;
                    script.scorevariable = script.SaveScoreReward5;
                    script.pointCountUpdate();
                    break;
                    }
            }
            else
            {
                //script.buttonset = script.completedContinue;
                switch (script.buttonset)
                {

                case 0:
                    ballt.position = spawnstart.position;
                    script.scorevariable = 0;
                    script.pointCountUpdate();
                    break;
                case 1:
                        ballt.position = spawnsave1.position;
                        script.scorevariable = script.SaveScoreReward1;
                        script.pointCountUpdate();
                        break;

                    case 2:
                        ballt.position = spawnsave2.position;
                        script.scorevariable = script.SaveScoreReward2;
                        script.pointCountUpdate();
                        break;

                    case 3:
                        ballt.position = spawnsave3.position;
                        script.scorevariable = script.SaveScoreReward3;
                        script.pointCountUpdate();
                        break;

                    case 4:
                        ballt.position = spawnsave4.position;
                        script.scorevariable = script.SaveScoreReward4;
                        script.pointCountUpdate();
                        break;

                    case 5:
                        ballt.position = spawnsave5.position;
                        script.scorevariable = script.SaveScoreReward5;
                        script.pointCountUpdate();
                    break;
                }
            
            }
   
        rigid = rigid.GetComponent<Rigidbody>();
        rigid.isKinematic = true;
        score_stuff.SetActive(false);
        ball.SetActive(true);
        continue_after_reward_ad.SetActive(false);
        reward_save.SetActive(false);
        spawn_effects.position = ballt.position;
        level_respawn.Play();
        spawn_particle.Play();
        restartt.position = location.position;
        script.haveReward = false;

        StartCoroutine(wait());
        IEnumerator wait()
        {
            yield return new WaitForSeconds(2);

            rigid.isKinematic = false;
            jumping.SetActive(true);
            Highscore_title.SetActive(false);
            restartobj.SetActive(false);

            for (int j = 0; j < parentTransform.childCount; j++)
            {
                parentTransform.GetChild(j).gameObject.SetActive(true);
            }
        }
    }

   
}
