using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextBySlide : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textToChangeSlide;
    [SerializeField] private Slider slideValue;

    private void Update()
    {
        slideValue.onValueChanged.AddListener((v) =>
        {
            textToChangeSlide.text = v.ToString("0.00");
        });
    }

    public void ValueChange()
    {
        textToChangeSlide.text = Convert.ToString(slideValue);
    }
}
