using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class UserName : MonoBehaviour
{
    public static string textName;
    public TextMeshProUGUI textField;
    
    void Start(){
    textName = textField.text;
    }
}