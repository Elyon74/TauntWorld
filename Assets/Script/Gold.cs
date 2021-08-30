using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public Players players;
    AudioSource coin;
    void Start()
    {

    }

    void Update()
    {
        coin = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            players.CurrentPlayerGold += 10;
            print ("Gold Actuel du joueur :" + players.CurrentPlayerGold);
            coin.Play();
            Destroy(gameObject, (float)0.4);
        }
    }
}
