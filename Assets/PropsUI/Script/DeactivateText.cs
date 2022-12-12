using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateText : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        StartCoroutine(waiter());
    }
    
    IEnumerator waiter(){
    yield return new WaitForSeconds(3);
    this.gameObject.SetActive(false);
    }
}
