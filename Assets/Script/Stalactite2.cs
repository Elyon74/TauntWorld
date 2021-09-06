using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalactite2 : MonoBehaviour
{

    public Rigidbody2D Stalactite02;
    public PlatformRockContact2 Rock2;
    public Players players;
    AudioSource DamageStala2;

    void Start()
    {
        Stalactite02 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Rock2.ContactStalac2 == true)
        {
            Destroy(gameObject, (float)0.8);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            players.CurrentPlayerHP -= 1;
            DamageStala2.Play();
        }
    }
}
