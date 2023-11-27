using UnityEngine;

public class cube_destroy10 : MonoBehaviour
{
    [SerializeField] private AudioSource au;
    [SerializeField] private ParticleSystem explode;
    [SerializeField] private ParticleSystem plus10;
    [SerializeField] private Transform explodep;
    [SerializeField] private Transform plus10p;
    [SerializeField] private coinLogic script;

    private void Update()
    {
        transform.Rotate(0f, 200f * Time.deltaTime, 0f, Space.Self);
    }

    private void OnTriggerEnter()
    {
        au.Play();
        gameObject.SetActive(false);
        explodep.position = transform.position;
        explode.Play();
        plus10p.position = transform.position;
        plus10.Play();
        script.scorevariable = script.scorevariable += 10;
        script.pointCountUpdate();
    }
}
