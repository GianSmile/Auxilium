using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CambiarDatos : MonoBehaviour
{
    [SerializeField] CPRScript cprScript;
    public TextMeshProUGUI handsOnData;
    public TextMeshProUGUI bpmData;
    public TextMeshProUGUI compressionData;
    public TextMeshProUGUI headData;
    private bool handsOn;
    private float bpmNumb;
    private int compressions;
    private bool headOnPosition;

    private void Update()
    {
        handsOn = cprScript.handsOnBody;
        bpmNumb = cprScript.bpm;
        headOnPosition = cprScript.headOnPosition;
        compressions = cprScript.compressions;
        handsOnData.text = "Manos en posicion: " + handsOn;
        bpmData.text = "BPM: " + bpmNumb.ToString("F2");
        compressionData.text = "Cantidad de compresiones: " + compressions.ToString();
        headData.text = "Cabeza en posicion: " + headOnPosition;
    }
}