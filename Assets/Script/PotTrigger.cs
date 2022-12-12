using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotTrigger : MonoBehaviour
{
    public GameObject cutsceneTrigger;
    public GameObject thePlayer;
    public GameObject canvas;
    public GameObject itemimage;
    public GameObject propimage;
    public GameObject objectActive;


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneTrigger.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());
       
        itemimage.SetActive(false);
        propimage.SetActive(false);
        canvas.SetActive(true);
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(8);

    }
}
