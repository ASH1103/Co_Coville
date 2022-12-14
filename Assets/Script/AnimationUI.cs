using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimationUI : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject objectActive;
    public GameObject winChar;
    public GameObject loseChar;
    private int index;
    public GameObject Cutscene;
    

    private GameObject back;
    private GameObject countinue;

    void Start()
    {
        textComponent.text = string.Empty;
        back = this.transform.Find("Back").gameObject;
        countinue = this.transform.Find("Continue").gameObject;

        if (objectActive.activeSelf)
        {
            index = 1;
            winChar.SetActive(true);
            StartDialogue();
            StartCutscene();
            countinue.SetActive(true);      
        }
        else
        {
            index = 0;
            loseChar.SetActive(true);
            StartDialogue();
            back.SetActive(true);
        }
    }

    // Update is called once per frame

    public void StartDialogue()
    {
        StartCoroutine(TypeLine());

    }
    
    public void StartCutscene()
    {
        StopCoroutine(TypeLine());
        Cutscene.SetActive(true);

    }
    

    

  
    IEnumerator TypeLine()
    {

        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
 

   



}
