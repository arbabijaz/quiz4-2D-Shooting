using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletPosition;
    public int health=40;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("fire", 1, 2);
        
    }

   
    void Update()
    {
        healthChecker();
    }
    void fire()
    {
        Instantiate(bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
       
    }
    void healthChecker()
    {
        if (health < 1)
            Destroy(gameObject);
    }
    public void getDamage(int damage)
    {
        health -= damage;
    }
}
