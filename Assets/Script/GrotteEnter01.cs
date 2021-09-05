using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrotteEnter01 : MonoBehaviour
{
    
    public RabbitCell01 RabbitCell001;
    private Transform PlayerSpawn4;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (RabbitCell001.AllRabbitInTheCell == true)
        {
            if (collision.CompareTag("Player"))
            {
               SceneManager.LoadScene(5);
               collision.transform.position = PlayerSpawn4.position;
            }
        }
    }
}