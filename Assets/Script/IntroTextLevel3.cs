using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroTextLevel3 : MonoBehaviour
{
     public TextMeshProUGUI textDisplay;
    

    
    void Start()
    {
        textDisplay.text = " " + UserName.textName + ", now that we've put on some nice clothes and bought all the snacks, we're ready to go to the party and can't wait! " ;
        
        StartCoroutine(TypeIntroText(textDisplay.text));
        textDisplay.text = " ";
    
    }
    
    IEnumerator TypeIntroText(string line){
    
    foreach(char c in line.ToCharArray()){
    textDisplay.text += c;
    yield return new WaitForSeconds(0.07f);
    }
    
    }
}
