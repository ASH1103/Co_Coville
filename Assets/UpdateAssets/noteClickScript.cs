using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class noteClickScript : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource button;
    public GameObject walkChar;
    public GameObject buttonContinue;
    // Start is called before the first frame update
    
    
    void OnMouseDown()
    {
     canvas.SetActive(true);
      //  this.GetComponent<AudioSource>().enabled = true;
     button.Play();
     walkChar.SetActive(false);
     buttonContinue.SetActive(true);
    }


}
