using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitCell01 : MonoBehaviour
{

    AudioSource coin;
    public bool AllRabbitInTheCell;
    int NumberofRabbit = 0;

    void Start()
    {
        coin = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (NumberofRabbit >= 2)
        {
            AllRabbitInTheCell = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rabbit"))
        {
            coin.Play();
            NumberofRabbit += 1;
        }
    }

}
