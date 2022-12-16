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
    private int cocoIndex;


    private int index;

    // Start is called before the first frame update
    void Start()
    {
     
        textComponent.text = string.Empty;
        StartDialogue();
        startButton = this.transform.Find("StartButton").gameObject;
        StartSound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&index!=6)
        {
            if (textComponent.text == lines [index])
            {
                NextLine();
                
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

    void StartSound()
    {
        cocoIndex=0;
     //   StartCoroutine(SoundStart());
    }

    //IEnumerator SoundStart()
   // {
     //   foreach (var s in cocoSound[cocoIndex])
      //  {
            
           // yield return new WaitForSeconds(textSpeed);
       // }
  //  }


    void NextLine ()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
            
            cocoIndex++;
            //StartCoroutine(SoundStart());
           

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



