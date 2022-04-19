using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1 : MonoBehaviour
{
    AudioSource Zone01;

    void Start()
    {
        Zone01 = GetComponent<AudioSource>();
        Zone01.Play();
    }


    void Update()
    {
        
    }
}
