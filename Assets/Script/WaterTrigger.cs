using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaterTrigger : MonoBehaviour
{

    public GameObject thePlayer;
    public ParticleSystem em;
    public GameObject canvas;
    public GameObject itemimage;
    public GameObject propimage;

    void Start ()
    {
        //water.GetComponent<ParticleSystem> ().enableEmission = false;
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.SetActive(false);
        em.GetComponent<ParticleSystem>().Play();
    
        StartCoroutine(StopWater());
        itemimage.SetActive(false);
        propimage.SetActive(false);
        canvas.SetActive(true);
    
       
    }

    IEnumerator StopWater()
    {
        yield return new WaitForSeconds(7);

        // water.GetComponent<ParticleSystem> ().enableEmission = false;
     
    }

}
