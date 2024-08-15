using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject tutorial;
    void Start(){
        tutorial.SetActive(true);
    }

    public void youCanChange(){
        tutorial.GetComponent<Tutorial>().Change();
    }
}
