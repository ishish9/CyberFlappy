using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectileiinstantiate : MonoBehaviour
{
    [SerializeField] private Transform SpawnLocation;
    [SerializeField] private GameObject Prefab;
    [SerializeField] private int FireAmount;
    [SerializeField] private float FireRate;

    public void OnTriggerEnter()
    {
        StartCoroutine(w1());
 
                IEnumerator w1()
                {
                    for (int j = 0; j < FireAmount; j++)
                    {
                    yield return new WaitForSeconds(FireRate);

                    Instantiate(Prefab, SpawnLocation.position, Quaternion.identity);
                    }
                }

        /*StartCoroutine(w2());
        IEnumerator w2()
        {
            yield return new WaitForSeconds(2);
            // Prefab2.transform.position = SpawnLocation.transform.position;
            //Prefab2.SetActive(true);
            Instantiate(Prefab, SpawnLocation.position, Quaternion.identity);

        }*/
    }
}
