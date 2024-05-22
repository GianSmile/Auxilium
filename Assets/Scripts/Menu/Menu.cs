using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu, options, levels;
    private void Start()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        levels.SetActive(false);

    }
    public void Play()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        levels.SetActive(true);
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
        levels.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        levels.SetActive(false);
    }
}
