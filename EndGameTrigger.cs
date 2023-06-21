using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    public GameObject endScreen;
    private float triggerCount = 0f;

    public GameObject run;
    public GameObject dontLookBack;

    public SKyBoxController sky;

    public AudioSource unknown;
    public AudioSource player;
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            triggerCount += 1;

        if(triggerCount <= 1)
            {
                run.SetActive(true);
                Invoke("DLBack", 1f);
                Destroy(run, 3f);
            }
        else if(triggerCount >= 2)
            {
                unknown.Stop();
                player.Stop();
                endScreen.SetActive(true);
                sky.ChangeSkyBox();
                Destroy(unknown.gameObject, 3f);
                Destroy(particle);
            }

        // FirstPersonController player = other.GetComponent<FirstPersonController>();
        // player.MoveSpeed /= 2f;
        // player.RotationSpeed += 3f;
        // player.SprintSpeed -= 2f;

            //endgame text "Congratulations!"
            //"You Won!"
            //"You stepped into the unknown!"
            //partypopper sound
            //confetti
            //reset effects
        }
    }

    private void DLBack()
    {
        dontLookBack.SetActive(true);
        Destroy(dontLookBack, 3f);
    }
}
