using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{
    public string _printtext;

    public void printText()
    {
        print(_printtext);
    }
    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play();
    }
  
        public Transform prefab;
    public void instansiateBluecube()
    {
        Instantiate(prefab, (transform.position), Quaternion.identity);

    }
    
}

