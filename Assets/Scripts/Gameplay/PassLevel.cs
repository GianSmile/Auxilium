using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLevel : MonoBehaviour
{
    public bool isVR;
    public GameDataController gdc;

    private void Start() {
        gdc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameDataController>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            if(SceneManager.GetActiveScene().name == "RCP"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
                gdc.PassLevel(1);
            }
            if(SceneManager.GetActiveScene().name == "Problemas respiratorios"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
                gdc.PassLevel(2);
            }
            if(SceneManager.GetActiveScene().name == "Quemaduras"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
                gdc.PassLevel(3);
            }
            if(SceneManager.GetActiveScene().name == "Intoxicaciones"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
                gdc.PassLevel(4);
            }
            if(SceneManager.GetActiveScene().name == "Cortes y heridas"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
                gdc.PassLevel(5);
            }
            if(SceneManager.GetActiveScene().name == "Reacciones alérgicas"){
                if(!isVR)SceneManager.LoadScene("Main Menu");
                if(isVR)SceneManager.LoadScene("Main Menu VR");
            }
        }
    }
}
