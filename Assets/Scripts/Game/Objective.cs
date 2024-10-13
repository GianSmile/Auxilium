using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public CPRScript cpr;
    public GameObject panel;
    public float startingTime = 60f;
    private float timer;

    private void Start()
    {
        timer = startingTime;
    }

    void Update()
    {
        if(cpr.bpm != 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = startingTime;
        }

        if(timer == 0){
            Debug.Log("Ganaste!");
            panel.SetActive(true);
        }
    }
}