using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    private bool isOptionsOn = false;
    public GameObject options;
    public void Resume(){
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Tutorial(){

    }
    public void Quit(){
        Application.Quit();
    }
    public void Menu(){
        SceneManager.LoadScene("Main Menu VR");
    }
    public void Options(){
        if (!isOptionsOn)
        {
            options.SetActive(true);
            isOptionsOn = true;
        }
        else
        {
            options.SetActive(false);
            isOptionsOn = false;
        }
    }
}
