using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectEnabled : MonoBehaviour
{

public GameObject[] uiObject;
GameObject dropObject;
int i;

   
   public void ActivatedObject(GameObject activatedObject){
    
    for (i=0; i<uiObject.Length; i++){
     if(uiObject[i].transform.GetChild(0).gameObject.activeSelf){
        dropObject = uiObject[i].transform.GetChild(1).gameObject;
        uiObject[i].transform.GetChild(0).gameObject.SetActive(false);

     }
     
    }
    
       activatedObject.SetActive(true);
       DisplayDropItemText();

    
    }
       
    
    public void DisplayDropItemText(){
    
   if(dropObject!=null){
    dropObject.SetActive(true);
    }

    }
    
 
}
