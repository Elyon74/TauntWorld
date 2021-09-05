using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked01 : MonoBehaviour
{

    public RabbitCell01 RabbitCell001;
    AudioSource rabbitinthescene;

    void Start()
    {
        rabbitinthescene = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (RabbitCell001.AllRabbitInTheCell == true)
        {
            rabbitinthescene.Play();
            Destroy(gameObject, (float)1);
        }
    }
}
