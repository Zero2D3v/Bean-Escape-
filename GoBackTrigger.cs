using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackTrigger : MonoBehaviour
{
    public GameObject goBack;
    // triggers the go back falling text objects to direct player back up the stairs towards the unknown
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goBack.SetActive(true);
            
        }
    }
}
