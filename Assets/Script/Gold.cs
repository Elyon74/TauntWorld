using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public Players players;
    public GoldNumber GoldNumber;
    AudioSource coin;

    void Start()
    {
        coin = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            players.CurrentPlayerGold += 10;
            print ("Gold Actuel du joueur :" + players.CurrentPlayerGold);
            coin.Play();
            GoldNumber.SetCountText();
            Destroy(gameObject, (float)0.3);
        }
    }
}
