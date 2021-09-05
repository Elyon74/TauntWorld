using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spider01 : MonoBehaviour
{

    private Transform PlayerSpawn3;
    public Players players;
    AudioSource DamageSpider;

    void Start()
    {
        DamageSpider = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (players.CurrentPlayerHP <= 0)
        {
            SceneManager.LoadScene(3);
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
            DamageSpider.Play();

        }
    }
}
