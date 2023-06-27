using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger2 : MonoBehaviour
{
    public AudioClip heartbeatFast;

    public AudioSource heartbeat;

    //2nd trigger in charge of increasing heartbeat and changing sky box
    public SKyBoxController sky;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            heartbeat.Stop();
            heartbeat.clip = heartbeatFast;
            heartbeat.Play();

            sky.ChangeSkyBox();

            Destroy(gameObject);
        }
    }
}
