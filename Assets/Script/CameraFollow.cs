using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       

   
    this. transform.position = player.transform.position + new Vector3(-55, 28, 0);
 

    }

}