using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float force = 5;
    private int damage = 20;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.up * force * Time.deltaTime);
        rg.AddForce(Vector2.down * force * Time.deltaTime);
        DestoryOutBound();
    }
    void DestoryOutBound()
    {
        if ( transform.position.y < -6)//transform.position.y > 8 ||
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("enemyBullet")) 
        {
            Debug.Log("enemy");
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), gameObject.GetComponent<BoxCollider2D>());
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collossion Enter player ");
            collision.gameObject.GetComponent<PlayerController>().getDamage(damage);
            Destroy(gameObject);
        }
        
    }
}
