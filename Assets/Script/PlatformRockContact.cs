using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRockContact : MonoBehaviour
{
    public Players players;
    public Stalactite1 stalactite1;
    public bool ContactStalac1;

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
            if (ContactStalac1 == false)
            {
                stalactite1.Stalactite01.WakeUp();
                ContactStalac1 = true;
            }
        }
    }
}
