using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChangeTextBySlide : MonoBehaviour
{
    public TextMeshProUGUI textToChangeSlide;
    public int slideValue;

    private void Update()
    {
        //slideValue = GameObject.Find("Test UI").GetComponent<Slider>().value;
    }

    public void ValueChange()
    {
        textToChangeSlide.text = Convert.ToString(slideValue);
    }
}
