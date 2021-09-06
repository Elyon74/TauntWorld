using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRockContact2 : MonoBehaviour
{
    public Players players;
    public Stalactite2 stalactite2;
    public bool ContactStalac2;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (ContactStalac2 == false)
            {
                stalactite2.Stalactite02.WakeUp();
                ContactStalac2 = true;
            }
        }
    }
}