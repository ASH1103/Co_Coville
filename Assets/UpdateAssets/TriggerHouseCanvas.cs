using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHouseCanvas : MonoBehaviour
{

    public GameObject canvas;
    public GameObject walkChar;
    public AudioSource button;
    public GameObject itemCanvas;
    public GameObject itemImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        canvas.SetActive(true);
        walkChar.SetActive(false);
        itemCanvas.SetActive(false);
        itemImage.SetActive(false);
        button.Play();
        canvas.GetComponent<houseEnterScript>().enabled = true;
        



        //  this.GetComponent<AudioSource>().enabled = true;

    }
}
