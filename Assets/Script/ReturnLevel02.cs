using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnLevel02 : MonoBehaviour
{
    private Transform PlayerSpawn2;
    public Players players;
    public RabbitCell01 RabbitCell001;
    public GameObject Rabbit;
    public GameObject Rabbit2;

    void Start()
    {
        Rabbit = GameObject.Find("Sprite-Rabbit01");
        Rabbit2 = GameObject.Find("Sprit-Rabbit02");
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
            collision.transform.position = PlayerSpawn2.position;
            RabbitCell001.AllRabbitInTheCell = true;
            Destroy(Rabbit);
            Destroy(Rabbit2);
        }
    }
}
