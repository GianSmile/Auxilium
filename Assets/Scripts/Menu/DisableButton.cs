using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button button;
    public Sprite normal;
    public Sprite disabled;
    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update(){
        if (button.enabled == true){
            button.image.overrideSprite = normal;
        }else{
            button.image.overrideSprite = disabled;
        }
    }
}
