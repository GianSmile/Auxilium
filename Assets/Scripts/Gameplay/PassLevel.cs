using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLevel : MonoBehaviour
{
    public bool isVR;
    private GameDataController gdc;
    public int levelToUnlock = 0;

    private void Start() {
        gdc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameDataController>();
        Debug.Log(SceneManager.GetActiveScene().name);
    }
    void Update()
    {
        //Ganar el nivel al apretar J
        if(Input.GetKeyDown(KeyCode.J)){
            //Volver al menú correspondiente dependiendo de si estamos en modo VR o no (mirar el script GameDataController)
            if (!isVR) SceneManager.LoadScene("Main Menu");
            if (isVR) SceneManager.LoadScene("Main Menu VR");
            
            //Desbloquear el nivel correspondiente. Como no se puede desbloquear el nivel 0 (ya que es el primer nivel y ya viene desbloqueda), se usa el 0 para indicar que no se desbloquea ninguno.
            if(levelToUnlock != 0)
            {
                gdc.UnlockLevel(levelToUnlock);
            }
        }
    }
}
