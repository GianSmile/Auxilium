using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CambiarDatos : MonoBehaviour
{
    [SerializeField] CPRScript cprScript;
    public TextMeshProUGUI handsOnData;
    public bool handsOn;

    private void Update()
    {
        handsOn = cprScript.handsOnBody;
        handsOnData.text = "Manos en posicion: " + handsOn;
    }
}
