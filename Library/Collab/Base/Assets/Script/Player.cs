using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;
    public GameObject crouch2;
    Rigidbody2D rb;

    bool isJumping;
    float player_posY;

    public GameManager gameManager;
    
    AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        bgm = GetComponent<AudioSource>();
        bgm.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        player_posY = transform.position.y;
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;
        }

        if (Input.GetKey("down") && isJumping == false && player_posY < -2.7 )
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
        else if(Input.GetKey("down") && isJumping == false && player_posY > -2.7)
        {
            crouch2.SetActive(true);
            stand.SetActive(false);
            crouch2.transform.position = new Vector3(-6.89f, -0.92f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
