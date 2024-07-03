using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLevel : MonoBehaviour
{
    public bool isVR;
    private GameDataController gdc;
    public int passLevel = 0;

    private void Start() {
        gdc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameDataController>();
        Debug.Log(SceneManager.GetActiveScene().name);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            if (!isVR) SceneManager.LoadScene("Main Menu");
            if (isVR) SceneManager.LoadScene("Main Menu VR");

            if(passLevel != 0)
            {
                gdc.PassLevel(passLevel);
            }
        }
    }
}
