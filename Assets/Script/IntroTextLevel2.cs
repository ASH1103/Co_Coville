using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroTextLevel2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    
    void Start()
    {
        textDisplay.text = " " + UserName.textName + ", now you got a gorgeous outfit. Let's go pick up some snacks. How can a perfect party be without chips? There is a supermarket at the end of this block, let's go! " ;
        
        StartCoroutine(TypeIntroText(textDisplay.text));
        textDisplay.text = " ";
    
    }
    
    IEnumerator TypeIntroText(string line)
    {
    
    foreach(char c in line.ToCharArray())
    {
    textDisplay.text += c;
    yield return new WaitForSeconds(0.07f);
    }
    
    }
}
