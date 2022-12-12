using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HomeButton : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(0);
    }
}
