using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
    [SerializeField] private GameObject xuit;
    [SerializeField] private GameObject postpros;
    [SerializeField] private GameObject background_particles;
    [SerializeField] private GameObject eye_circle;
    [SerializeField] private GameObject ball_trail_effect;
    [SerializeField] private GameObject End_particlfield;
    private bool onoff = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            xuit.gameObject.SetActive(true);
        }
    }
    public void quityes()
    {
        Application.Quit();
    }
    public void Grapphic_Settings()
    {
        if (onoff == true)
        {
            postpros.SetActive(true);
            background_particles.SetActive(true);
            eye_circle.SetActive(true);
            ball_trail_effect.SetActive(true);
            End_particlfield.SetActive(true);
            onoff = false;
        }
        else 
        {
            postpros.SetActive(false);
            background_particles.SetActive(false);
            eye_circle.SetActive(false);
            ball_trail_effect.SetActive(false);
            End_particlfield.SetActive(false);
            onoff = true;
        }
    }
}
