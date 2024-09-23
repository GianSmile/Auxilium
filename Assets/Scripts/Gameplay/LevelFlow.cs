using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFlow : MonoBehaviour
{
    int phase = 0;
    /*
    0 --> Inicio
    1 --> Entorno chequeado
    2 --> Ayuda aceptada
    3 --> 911 llamado
    4 --> MES realizado
    */

    public GameObject inicio; //Burbuja de texto inicial
    public GameObject ayuda;
    public GameObject buscarPersonas;
    public GameObject realizarMES;
    public GameObject realizarRCP;
    void Start(){
        Inicio();
    }

    void Inicio(){
        phase = 0;
        inicio.SetActive(true);
        //...
    }

    void EntornoChequeado(){
        phase = 1;
        ayuda.SetActive(true);
        //...
    }

    void AyudaAceptada(){
        phase = 2;
        buscarPersonas.SetActive(true);
        //...
    }
    void AmbulanciaLlamada(){
        phase = 3;
        realizarMES.SetActive(true);
        //...
    }
    void HacerRCP(){
        phase = 4;
        realizarRCP.SetActive(true);
        //...
    }

    void Update(){
        if(phase == 0){
            
        }
        if(phase == 1){
            
        }
        if(phase == 2){
            
        }
        if(phase == 3){
            
        }
        if(phase == 4){
            
        }
    }
}
