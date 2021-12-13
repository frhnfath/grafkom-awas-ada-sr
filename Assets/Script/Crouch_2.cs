using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch_2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;

    public GameManager gameManager;
    
    AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            stand.SetActive(true);
            crouch.SetActive(false);
            stand.transform.position = new Vector3(-6.733f, -2.764f, -2.764f);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
