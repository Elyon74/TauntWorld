using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grotte2 : MonoBehaviour
{
    private Transform PlayerSpawn4;
    public Players players;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(6);
            collision.transform.position = PlayerSpawn4.position;
        } */
    }
}
