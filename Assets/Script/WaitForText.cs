using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForText : MonoBehaviour
{
   
   public GameObject text;
    
    void Start()
    {
        StartCoroutine(Wait());
    }

   
    IEnumerator Wait(){
    yield return new WaitForSeconds(6);
    Debug.Log("Hello");
    text.SetActive(true);
    
    }
}
