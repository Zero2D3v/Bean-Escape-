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
            //makes sure you only win the game if its the 2nd time you've gone up the stairs
            triggerCount += 1;

        if(triggerCount <= 1)
            {
                //triggers the run dont look back text objects fall ontop of player and encourage player to run down stairs away from unknown
                run.SetActive(true);
                Invoke("DLBack", 1f);
                Destroy(run, 3f);
            }
        else if(triggerCount >= 2)
            {
                //win state called if player steps into unknown after running away
                //stop scary sounds and heavy heartbeat and reset sky box
                unknown.Stop();
                player.Stop();
                endScreen.SetActive(true);
                sky.ChangeSkyBox();
                Destroy(unknown.gameObject, 3f);
                Destroy(particle);
            }
            //pre-implementation notes and ideas
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
