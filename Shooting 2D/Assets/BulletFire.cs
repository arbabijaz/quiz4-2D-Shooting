using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{

    public float force = 5;
    private int damage = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*force*Time.deltaTime);
        DestoryOutBound();
    }
    void DestoryOutBound()
    {
        if (transform.position.y > 8 || transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collossion Enter Enemy ");
            collision.gameObject.GetComponent<EnemyController>().getDamage(damage); 
            //gameObject.GetComponent<PlayerController>().UpdateScore(10);
            Destroy(gameObject);
        }
    }
    
}
