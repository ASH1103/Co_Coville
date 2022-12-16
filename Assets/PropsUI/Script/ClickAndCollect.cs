using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndCollect : MonoBehaviour
{
  
public GameObject canvas;


    void OnMouseDown()
    {
     canvas.SetActive(true);
      //  this.GetComponent<AudioSource>().enabled = true;
     
    }

}
