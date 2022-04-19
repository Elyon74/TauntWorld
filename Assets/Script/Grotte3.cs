using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grotte3 : MonoBehaviour
{
    private Transform PlayerSpawn2;
    public Players players;
    AudioSource Grotte03;

    void Start()
    {
        Grotte03 = GetComponent<AudioSource>();
        Grotte03.Play();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(7);
            collision.transform.position = PlayerSpawn2.position;
        }
    }
}