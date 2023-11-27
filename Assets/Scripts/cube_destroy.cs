using UnityEngine;

public class cube_destroy : MonoBehaviour
{
    [SerializeField] private AudioSource au;
    [SerializeField] private ParticleSystem explode;
    [SerializeField] private ParticleSystem plus1;
    [SerializeField] private Transform explodep;
    [SerializeField] private Transform plus1p;
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
        plus1p.position = transform.position;
        plus1.Play();
        script.scorevariable++;
        script.pointCountUpdate();
    }
}
