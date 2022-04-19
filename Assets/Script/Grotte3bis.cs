using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grotte3bis : MonoBehaviour
{
    AudioSource Grotte03bis;

    void Start()
    {
        Grotte03bis = GetComponent<AudioSource>();
        Grotte03bis.Play();
    }

    void Update()
    {
        
    }
}
