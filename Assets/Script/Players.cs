using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    public int MaxPlayerHP = 3;
    public int CurrentPlayerHP = 3;
    public int MaxPlayerGold = 999;
    public int CurrentPlayerGold = 0;
    public int MaxPlayerLevel = 99;
    public int CurrentPlayerLevel = 1;
    public int CurrentPlayerExp = 0;
    public float walkspeed;
    public float jumpforce;
    public bool isJumping;
    public bool isGrounded;
    public bool attack;
    private Vector3 velocity = Vector3.zero;
    public Rigidbody2D RigidPlayer;
    public BoxCollider2D ColliderPlayer;
    public SpriteRenderer PlayerSpriteRenderer;
    public Sword01 Sword01;
    AudioSource jump;

    // Vector 2 2D, Vector3 3D
    private void Awake()
    {
        PlayerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        print("Level Actuel du joueur : " + CurrentPlayerLevel);
        print("HP Actuel du joueur : " + CurrentPlayerHP);
        print("Gold Actuel du joueur : " + CurrentPlayerGold);
        print("Exp Actuel du joueur : " + CurrentPlayerExp);
    }

    void Update()
    {
        HP(CurrentPlayerHP);
        Level(CurrentPlayerLevel);
        Jump(jumpforce);
        jump = GetComponent<AudioSource>();

        float horizontalMovement = Input.GetAxis("Horizontal") * walkspeed * Time.deltaTime;
        PlayerMove2(horizontalMovement);

        if (RigidPlayer.velocity.y == 0)
            isGrounded = true;
        else
            isGrounded = false;

            if (Input.GetKeyDown("q"))
            {
                if (PlayerSpriteRenderer != null)
                {
                    PlayerSpriteRenderer.flipX = true;
                }
            }

            if (Input.GetKeyDown("d"))
            {
                if (PlayerSpriteRenderer != null)
                {
                    PlayerSpriteRenderer.flipX = false;

                }
            }

            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(2);
            }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (Sword01.swordweaponacquired == true)
                {
                    attack = true;
                }
            }
    }

    public void HP(float CurrentPlayerHP)
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
        if (CurrentPlayerHP <= 0)
        {
            GameObject HP1 = GameObject.Find("Sprite-HP1");
            GameObject HP2 = GameObject.Find("Sprite-HP2");
            GameObject HP3 = GameObject.Find("Sprite-HP3");
            Destroy(HP3);
            Destroy(HP2);
            Destroy(HP1);
        }
    }

    public void Level(float CurrentPlayerLevel)
    {
        if (CurrentPlayerLevel == 1)
        {
            GameObject SpriteLvl1 = GameObject.Find("SpriteLvl1");
        }

        if (CurrentPlayerLevel == 2)
        {
            GameObject SpriteLvl1 = GameObject.Find("SpriteLvl1");
            GameObject SpriteLvl2 = GameObject.Find("SpriteLvl2");
            Destroy(SpriteLvl1);
            Instantiate(SpriteLvl2, new Vector2((float)-4.01, (float)7.02), Quaternion.identity); // Need change the position just after Vector3 for screen position
        }

        if (CurrentPlayerLevel == 3)
        {
            GameObject SpriteLvl1 = GameObject.Find("SpriteLvl1");
            GameObject SpriteLvl2 = GameObject.Find("SpriteLvl2");
            GameObject SpriteLvl3 = GameObject.Find("SpriteLvl3");
            Destroy(SpriteLvl1);
            Destroy(SpriteLvl2);
            Instantiate(SpriteLvl3, new Vector2((float)-4.01, (float)7.02), Quaternion.identity); // Need change the position just after Vector3 for screen position
        }
    }

    public void ExpMax()
    {
        if (CurrentPlayerExp < 100)
        {
            CurrentPlayerLevel = 1;
        }

        if (CurrentPlayerExp == 100)
        {
            CurrentPlayerLevel = 2;
        }

        if (CurrentPlayerExp == 200)
        {
            CurrentPlayerLevel = 3;
        }
    }

    void Jump(float jumpforce)
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
            jump.Play();
        }
    }

    void PlayerMove2(float _horizontalMovement)
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