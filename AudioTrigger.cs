using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource theUnknown;

    public AudioClip heartbeatSLow;
    
    public AudioSource heartbeat;

    public SKyBoxController sky;

    //1st trigger in charge of heartbeat sound and starting eerie sound attached to 'Unknown' object at top of stairs so if you turn the sound is located in 3D
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
