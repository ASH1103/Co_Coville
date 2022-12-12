using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject canvas;
    public GameObject character;
    public GameObject itemCanvas;
    public GameObject item;
    
    void OnTriggerEnter(Collider other)
    {
       character.SetActive(false);
       canvas.SetActive(true);
       itemCanvas.SetActive(false);
       item.SetActive(false);
       
    }
}
