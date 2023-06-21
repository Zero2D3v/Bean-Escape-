using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource theUnknown;

    public AudioClip heartbeatSLow;
    
    public AudioSource heartbeat;

    public SKyBoxController sky;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            theUnknown.Play();
            heartbeat.PlayOneShot(heartbeatSLow);

            sky.ChangeSkyBox();

            Destroy(gameObject);
        }
    }
}
