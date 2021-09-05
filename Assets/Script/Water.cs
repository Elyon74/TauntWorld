using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour
{
    private Transform PlayerSpawn;
    public Players players;
    AudioSource Damage;

    void Start()
    {
        Damage = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (players.CurrentPlayerHP == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void Awake()
    {
        PlayerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
                collision.transform.position = PlayerSpawn.position;
                players.CurrentPlayerHP -= 1;
            Damage.Play();

        }
    }
}
