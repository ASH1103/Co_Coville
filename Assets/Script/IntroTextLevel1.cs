using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroTextLevel1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    

    
    void Start()
    {
        textDisplay.text = " Hello, " +  UserName.textName + ", your journey begins now! Let's go to the exciting New Year Party! First, we need to stop by the Clothing Shop, to buy a cute outfit for the party! Let's go!" ;
        
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
