using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnLevel01 : MonoBehaviour
{
    private Transform PlayerSpawnbis;
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
            SceneManager.LoadScene(3);
            collision.transform.position = PlayerSpawnbis.position;
        }
    }
}