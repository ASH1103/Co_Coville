using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudtrigger : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject canvas;
    public GameObject itemimage;
    public GameObject propimage;


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.SetActive(false);

        itemimage.SetActive(false);
        propimage.SetActive(false);
        canvas.SetActive(true);

    }

  
}
