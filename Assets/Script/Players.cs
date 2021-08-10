using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public int MaxPlayerHP = 3;
    public int CurrentPlayerHP = 3;
    public int MaxPlayerGold = 999;
    public int CurrentPlayerGold = 0;
    public int MaxPlayerLevel = 99;
    public int CurrentPlayerLevel = 1;
    public float walkspeed;
    public float jumpforce;
    public bool isJumping;
    public bool isGrounded;
    private Vector3 velocity = Vector3.zero;
    public Rigidbody2D RigidPlayer;
    public BoxCollider2D ColliderPlayer;
    public SpriteRenderer PlayerSpriteRenderer;

    private void Awake()
    {
        PlayerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        print("Level Actuel du joueur : " + CurrentPlayerLevel);
        print("HP Actuel du joueur : " + CurrentPlayerHP);
        print("Gold Actuel du joueur : " + CurrentPlayerGold);
    }

    void Update()
    {
        HP(CurrentPlayerHP);
        Level(CurrentPlayerLevel);
        Gold(CurrentPlayerGold);
        Jump(jumpforce);

        void HP(float CurrentPlayerHP)
        {
            if (CurrentPlayerHP == 2)
            {
                GameObject HP3 = GameObject.Find("Sprite-HP3");
                Destroy(HP3);
            }
            if (CurrentPlayerHP == 1)
            {
                GameObject HP2 = GameObject.Find("Sprite-HP2");
                GameObject HP3 = GameObject.Find("Sprite-HP3");
                Destroy(HP3);
                Destroy(HP2);
            }
            if (CurrentPlayerHP == 0)
            {
                GameObject HP1 = GameObject.Find("Sprite-HP1");
                GameObject HP2 = GameObject.Find("Sprite-HP2");
                GameObject HP3 = GameObject.Find("Sprite-HP3");
                Destroy(HP3);
                Destroy(HP2);
                Destroy(HP1);
            }
        }

        void Level(float CurrentPlayerLevel)
        {
            if (CurrentPlayerLevel == 2)
            {
                GameObject SpriteLvl1 = GameObject.Find("SpriteLvl1");
                Destroy(SpriteLvl1);
                // Ici on spawn le GameObject Lvl2 idem pour les prochains level
            }
            if (CurrentPlayerLevel == 3)
            {
                GameObject SpriteLvl1 = GameObject.Find("SpriteLvl1");
                GameObject SpriteLvl2 = GameObject.Find("SpriteLvl2");
                Destroy(SpriteLvl1);
                Destroy(SpriteLvl2);
            }
        }
        void Gold(float CurrentPlayerGold)
        {

        }

        void Jump(float jumpforce)
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                isJumping = true;
            }
        }

        // Vector 2 = Axe vertical, Vector 3 = Axe horizontal

        float horizontalMovement = Input.GetAxis("Horizontal") * walkspeed * Time.deltaTime;
        PlayerMove(horizontalMovement);
        if (RigidPlayer.velocity.y == 0)
            isGrounded = true;
        else
            isGrounded = false;

        if (Input.GetKeyDown("q"))
        {
            if (PlayerSpriteRenderer != null)
            {
                // flip the sprite
                PlayerSpriteRenderer.flipX = true;
            }
        }

        if (Input.GetKeyDown("d"))
        {
            if (PlayerSpriteRenderer != null)
            {
                // flip the sprite
                PlayerSpriteRenderer.flipX = false;

            }
        }

         void PlayerMove(float _horizontalMovement)
        {
                Vector3 targetVelocity = new Vector2(_horizontalMovement, RigidPlayer.velocity.y);
                RigidPlayer.velocity = Vector3.SmoothDamp(RigidPlayer.velocity, targetVelocity, ref velocity, .05f);
                if (isJumping == true)
                {
                    RigidPlayer.AddForce(new Vector2(0f, jumpforce));
                    isJumping = false;
                }
        }
    }
}