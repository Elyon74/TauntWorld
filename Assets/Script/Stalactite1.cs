using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stalactite1 : MonoBehaviour
{

    public Rigidbody2D Stalactite01;
    public PlatformRockContact Rock1;
    public Players players;
    AudioSource DamageStala;

    void Start()
    {
        Stalactite01 = GetComponent<Rigidbody2D>();
        DamageStala = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Rock1.ContactStalac1 == true)
        {
            Destroy(gameObject, (float)0.85);
        }

        if (players.CurrentPlayerHP <= 0)
        {
            DamageStala.Play();
            SceneManager.LoadScene(1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            players.CurrentPlayerHP -= 1;
            DamageStala.Play();
        }
    }
}