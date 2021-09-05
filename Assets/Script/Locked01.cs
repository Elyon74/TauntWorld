using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked01 : MonoBehaviour
{

    public RabbitCell01 RabbitCell001;
    public GrotteEnter01 Grotte01;

    void Start()
    {

    }


    void Update()
    {
        if (RabbitCell001.AllRabbitInTheCell == true)
        {
            Grotte01.rabbitinthescene.Play();
            Destroy(gameObject, (float)0.3);
        }
    }
}
