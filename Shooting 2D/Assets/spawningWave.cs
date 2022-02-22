using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningWave : MonoBehaviour
{
    public GameObject enemy;
    //private UIButtons uIButtons;
    public float horizontalSpac=-6;
    public float verticalSpace=-4;
    int row=4;
    int col=7;
    //public bool gamestart = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //uIButtons = GetComponent<UIButtons>();
        //row = uIButtons.row;     UI logic is not working 
        //col = uIButtons.col;
        //if (gamestart)
        //{
           
        //}
        wavespowning();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void wavespowning()
    {
        Debug.Log("spawn");
        float temp = horizontalSpac;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                InstentiateEnemy();
                horizontalSpac += 2.5f;
            }
            verticalSpace -= 2.5f;
            horizontalSpac = temp;
        }
    }
    void InstentiateEnemy()
    {
        Instantiate(enemy, new Vector2(horizontalSpac, verticalSpace), enemy.transform.rotation);
        
    }
   
}
