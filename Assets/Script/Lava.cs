using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{

    public Transform PlayerSpawn3;
    public Players players;
    AudioSource DamageLava;

    void Start()
    {
        DamageLava = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (players.CurrentPlayerHP <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Awake()
    {
        PlayerSpawn3 = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = PlayerSpawn3.position;
            players.CurrentPlayerHP -= 1;
            DamageLava.Play();

        }
    }
}
