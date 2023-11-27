using UnityEngine;

public class wind1 : MonoBehaviour
{
    public float Y;

    void OnTriggerStay(Collider rig)
    {
        rig.attachedRigidbody.AddForce(0f, Y, 0f, ForceMode.Impulse);
    }
}
