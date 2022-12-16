using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButoon : MonoBehaviour
{
    public GameObject levelA;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivateLevel());
    }

    // Update is called once per frame
    IEnumerator ActivateLevel()
    {
        yield return new WaitForSeconds(15.5f);
        levelA.SetActive(true);
        
    }
}
