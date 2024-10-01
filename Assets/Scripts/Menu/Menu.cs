using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu, options, levels;
    public Button[]buttons;
    public GameDataController gdc;
    private bool isOptionsOn = false;
    private void Start()
    {
        gdc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameDataController>();
        mainMenu.SetActive(true);
        options.SetActive(false);
        levels.SetActive(false);

    }
    public void Play()
    {
        /*mainMenu.SetActive(false);
        options.SetActive(false);
        levels.SetActive(true);*/
        SceneManager.LoadScene("Escenario");
    }

    public void Options()
    {
        if(!isOptionsOn){
            mainMenu.SetActive(false);
            options.SetActive(true);
            levels.SetActive(false);
            isOptionsOn = true;
        }else{
            mainMenu.SetActive(true);
            options.SetActive(false);
            levels.SetActive(false);
            isOptionsOn = false;
        }
 
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

    public void RCP(){
        SceneManager.LoadScene("RCP");
    }

    public void ProblemasRespiratorios(){
        SceneManager.LoadScene("Problemas respiratorios");
    }

    public void Quemaduras(){
        SceneManager.LoadScene("Quemaduras");
    }

    public void Intoxicaciones(){
        SceneManager.LoadScene("Intoxicaciones");
    }

    public void CortesYHeridas(){
        SceneManager.LoadScene("Cortes y heridas");
    }

    public void ReaccionesAlergicas(){
        SceneManager.LoadScene("Reacciones alérgicas");
    }

    private void Update() {
        //Bloquear los botones de los niveles bloqueados
        for(int i = 0; i < 6; i++){
            buttons[i].enabled = gdc.levels[i];
        }
    }
}
