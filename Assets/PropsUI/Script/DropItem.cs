using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject objectToDrop;
    int i=0;
    
  
  
    void Update(){
    
    do{
      objectToDrop.SetActive(true);
     objectToDrop.transform.GetChild(1).gameObject.SetActive(false);
     i++;
    
    
    }while(i==0);
     
    
 
     }
    
    
    }

    
    
    

