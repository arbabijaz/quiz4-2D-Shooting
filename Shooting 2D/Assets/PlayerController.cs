using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    private Rigidbody2D playerRG;
    public GameObject bullet;
    public GameObject bulletPosition;
    private float dirx = 0f;
    private float diry = 0f;
    public float moveSpeed = 7f;
    public int health = 100;
    public int score = 0;
    
    

    void Start()
    {
        playerRG = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        playerMovament();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }
        healthChecker();

    }
    void playerMovament()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        playerRG.velocity = new Vector2(dirx * moveSpeed, playerRG.velocity.y);
        diry = Input.GetAxisRaw("Vertical");
        playerRG.velocity = new Vector2(playerRG.velocity.x, diry * moveSpeed);
    }
    public void fire()
    {
        Instantiate(bullet,bulletPosition.transform.position,bulletPosition.transform.rotation);
        //Debug.Log("fire");
    }
    public void getDamage(int damage)
    {
        health -= damage;
    }
    void healthChecker()
    {
        if (health < 1)
            Destroy(gameObject);
    }
    public void UpdateScore(int score )
    {
        this.score +=score;
    }
}
