using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private GameObject startButton;
    public AudioSource[] cocoSound;
    private int cocoIndex=0;


    private int index;

    // Start is called before the first frame update
    void Start()
    {
     
        textComponent.text = string.Empty;
        StartDialogue();
        startButton = this.transform.Find("StartButton").gameObject;
        cocoSound[cocoIndex].Play();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&index!=6)
        {   
            
          
            if (textComponent.text == lines [index])
            {
                NextLine();
                
                cocoSound[cocoIndex-1].Stop();
                cocoSound[cocoIndex].Play();
                
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {             
        foreach (char c in lines [index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);                       
        }
    }

  

 

    void NextLine ()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
            
            cocoIndex++;

        if (index == 6)
        {
            startButton.SetActive(true);
        }

        }

      
        else
        {
            gameObject.SetActive(false);
        }

    }

}



