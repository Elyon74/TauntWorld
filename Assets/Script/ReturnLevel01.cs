using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnLevel01 : MonoBehaviour
{
    private Transform PlayerSpawn3;
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
            SceneManager.LoadScene(1);
            collision.transform.position = PlayerSpawn3.position;
        }
    }
}