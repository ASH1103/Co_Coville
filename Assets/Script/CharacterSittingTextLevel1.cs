using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSittingTextLevel1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
  



    void Start()
    {
        textDisplay.text = " Holiday season! I saw some kids were playing with water on the roof";

        StartCoroutine(TypeHintText(textDisplay.text));
        textDisplay.text = " ";
    }

    IEnumerator TypeHintText(string line)
    {

        foreach (char c in line.ToCharArray())
        {
            textDisplay.text += c;
            yield return new WaitForSeconds(0.05f);
        }

    }
}

