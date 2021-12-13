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
    float timer = 0;
    float player_posY;

    public GameManager gameManager;
    public AudioSource sfx;

    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        sfx = GetComponent<AudioSource>();
        
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
        timer+=Time.deltaTime;
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

        if (collision.tag == "powerUps")
        {
            Destroy(GameObject.Find("powerUp(Clone)"));
            sfx.Play();
        }
        /*{
            while ( timer < maxtime)
            {
                 if(timer % 2f == 0f) stand.SetActive(false);
                 else stand.SetActive(true);
            }
            stand.SetActive(true);
            timer = 0;
        }*/
    }   

     
         
    
  
     


}
