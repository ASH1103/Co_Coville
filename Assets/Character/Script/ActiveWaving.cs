using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWaving : MonoBehaviour
{

    public GameObject dialogue;
    public GameObject character;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.activeSelf)
        {
            character.SetActive(true);
        }
        
    }
}
