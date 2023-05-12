using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class houseEnterScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;


    
    void OnEnable()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame


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
