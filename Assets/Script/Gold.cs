using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public Players players;
    public GameObject numberofcoin;
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
            Destroy(gameObject, (float)0.3);
            Instantiate(numberofcoin, new Vector2(-9, 5), Quaternion.identity);
        }
    }
}
