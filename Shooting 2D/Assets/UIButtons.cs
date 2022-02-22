using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    public GameObject mainManu;
    public GameObject selectDef;
    public GameObject health;
    public GameObject score;
    public GameObject sound;
    //spawningWave spawningWav;
    public int row = 0;
    public int col = 0;
    // Start is called before the first frame update
    void Start()
    {
        //spawningWav = GetComponent<spawningWave>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onstart()
    {
        mainManu.SetActive(false);
        selectDef.SetActive(true);
       
    }
    public void quit()
    {
        selectDef.SetActive(false);
        mainManu.SetActive(true);
        sound.SetActive(false);
    }
    public void easy()
    {
        row = 3;
        col = 4;
        selectDef.SetActive(false);
        health.SetActive(true);
        score.SetActive(true);
        //spawningWav.gamestart = true; 

    }
    public void medium()
    {
        row = 4;
        col = 5;
        selectDef.SetActive(false);
        health.SetActive(true);
        score.SetActive(true);
        //spawningWav.gamestart = true;
    }
    public void hard()
    {
        row = 4;
        col = 7;
        selectDef.SetActive(false);
        health.SetActive(true);
        score.SetActive(true);
        //spawningWav.gamestart = true;

    }
    public void soundPanal()
    {
        sound.SetActive(true);
    }
    
}
