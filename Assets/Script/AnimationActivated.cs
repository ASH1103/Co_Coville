using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivated : MonoBehaviour
{
    public GameObject balloon;
    public GameObject balloon1;
    public GameObject balloon2;
    public GameObject balloon3;
    public GameObject balloon4;
    public GameObject plane;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
         ActivateAnimation();
    }

    // Update is called once per frame
    void ActivateAnimation(){
       balloon.GetComponent<Animator>().enabled = true;
       Debug.Log("Hey");
       balloon1.GetComponent<Animator>().enabled = true;
       balloon2.GetComponent<Animator>().enabled = true;
       balloon3.GetComponent<Animator>().enabled = true;
       balloon4.GetComponent<Animator>().enabled = true;
       plane.GetComponent<Animator>().enabled = true;
    }
}
