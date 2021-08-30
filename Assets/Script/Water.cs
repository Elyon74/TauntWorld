using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour
{
    private Transform PlayerSpawn;
    public Players players;

    void Start()
    {

    }

    void Update()
    {
        if (players.CurrentPlayerHP == 0)
        {
            SceneManager.LoadScene(3);
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
        }
    }
}
