using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHintLevel1 : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource button;
    public GameObject camera;
    public GameObject hintCamera;
    public GameObject walkChar;
    public GameObject continueButton;
  


    void OnMouseDown()
    {
        canvas.SetActive(true);
        camera.SetActive(false);
        hintCamera.SetActive(true);
        walkChar.SetActive(false);
        button.Play();

        continueButton.SetActive(true);
       


        //  this.GetComponent<AudioSource>().enabled = true;

    }


    
        



}
