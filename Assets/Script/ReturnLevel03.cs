using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnLevel03 : MonoBehaviour
{

    private Transform PlayerSpawn3bis;
    public Players players;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(5);
            collision.transform.position = PlayerSpawn3bis.position;
        }
    }
}
