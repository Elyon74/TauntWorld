using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zone2 : MonoBehaviour
{
    private Transform PlayerSpawn2;
    public Players players;
    AudioSource Zone02;

    void Start()
    {
        Zone02 = GetComponent<AudioSource>();
        Zone02.Play();
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
        }
    }
}