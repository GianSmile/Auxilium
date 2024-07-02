using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    private Button button;
    private Sprite normal;
    public Sprite disabled;
    void Start()
    {
        normal = gameObject.GetComponent<Image>().sprite;
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
