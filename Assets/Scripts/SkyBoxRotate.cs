using UnityEngine;

public class SkyBoxRotate : MonoBehaviour
{
    public float Rotate = 5f;
       
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * Rotate);
    }
}
