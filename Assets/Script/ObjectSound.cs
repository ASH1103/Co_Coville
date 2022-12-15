using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSound : MonoBehaviour
{
    
 public AudioSource itemSound;

 private void OnTriggerEnter(Collider other)
 {
    if(other.gameObject.tag == "Player")
    {
        itemSound.Play();
    }
 }
 
}
