using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCollectAudio : MonoBehaviour



{

    public AudioSource collectSound;

 
    // Update is called once per frame
    void playSound()
    {
        collectSound.Play();
    }


}
