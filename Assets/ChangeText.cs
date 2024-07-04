using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI textToChange;
    public string text = "Pressed";

    public void ValueChange()
    {
        textToChange.text = text;
    }
}
