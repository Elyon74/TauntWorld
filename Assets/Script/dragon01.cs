using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon01 : MonoBehaviour
{
    [SerializeField]
    public int MaxDragonHP = 3;
    public int CurrentDragonHP = 3;
    public int DragonExpOnKill = 50;
    public float walkspeed;
    public float jumpforce;
    public bool isJumping;
    public bool isGrounded;
    public bool attack;
    private Vector3 velocity = Vector3.zero;
    public Rigidbody2D RigidPlayer;
    public BoxCollider2D ColliderPlayer;
    public SpriteRenderer PlayerSpriteRenderer;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
