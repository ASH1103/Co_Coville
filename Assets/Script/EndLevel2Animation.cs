using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndLevel2Animation : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject winChar;
    
    
    void Start()
    {
            StartDialogue();
    }

    public void StartDialogue()
    {
        StartCoroutine(TypeLine());

    }

  
    IEnumerator TypeLine()
    {

        foreach (char c in lines[0].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
