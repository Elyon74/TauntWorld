using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire01 : MonoBehaviour
{

    public Transform PlayerSpawn3;
    public Players players;
    public Sword01 Sword01;
    AudioSource DamageFire;

    void Start()
    {
        DamageFire = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (players.CurrentPlayerHP <= 0)
        {
            SceneManager.LoadScene(1);
        }

        if (Sword01.swordweaponacquired == true)
        {
            Destroy(gameObject, (float)0.2);
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
            DamageFire.Play();

        }
    }
}
