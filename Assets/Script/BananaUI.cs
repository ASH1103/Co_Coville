using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BananaUI : MonoBehaviour
{
    // Start is called before the first frame update
  
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject loseChar;
    public GameObject character;
    public GameObject itemCanvas;
    public GameObject propCanvas;

    private int index;



    void Start()
    {
        textComponent.text = string.Empty;
        loseChar.SetActive(true);
        character.SetActive(false);
        itemCanvas.SetActive(false);
        propCanvas.SetActive(false);
        StartDialogue();

    }


    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    // Update is called once per frame
  
}
