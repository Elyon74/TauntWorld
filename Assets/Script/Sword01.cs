using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword01 : MonoBehaviour
{

    public Players players;
    public bool swordweaponacquired;
    AudioSource sword;

    void Start()
    {
        sword = GetComponent<AudioSource>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            swordweaponacquired = true;
            print("Epée acquise !");
            sword.Play();
            Destroy(gameObject, (float)0.3);
        }
    }
}
