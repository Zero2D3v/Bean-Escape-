using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public AudioClip partyBlow;
    public AudioSource unknown;

    public GameObject confetti;

    private void OnEnable()
    {
        unknown.PlayOneShot(partyBlow);
        //Instantiate(confetti, //)
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
