using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grotte2 : MonoBehaviour
{
    private Transform PlayerSpawn4;
    public Players players;
    AudioSource Grotte02;

    void Start()
    {
        Grotte02 = GetComponent<AudioSource>();
        Grotte02.Play();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(6);
            collision.transform.position = PlayerSpawn4.position;
        }
    }
}
