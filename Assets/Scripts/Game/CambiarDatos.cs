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
    public TextMeshProUGUI breathingData;
    private bool handsOn;
    private float bpmNumb;
    private int compressions;
    private bool headOnPosition;
    private bool breathing;
    private bool gameEnded;

    private void Update()
    {
        handsOn = cprScript.handsOnBody;
        bpmNumb = cprScript.bpm;
        headOnPosition = cprScript.headOnPosition;
        compressions = cprScript.compressions;
        breathing = cprScript.checkedBreathing;

        if (gameEnded == false)
        {
            handsOnData.text = "Manos en posicion: " + handsOn;
            bpmData.text = "CPM: " + bpmNumb.ToString("F2") + " (mantener entre 100 - 120)";
            compressionData.text = "Cantidad de compresiones: " + compressions.ToString();
            headData.text = "Cabeza en posicion: " + headOnPosition;
            breathingData.text = "Checkeo respiracion: " + breathing;
        }

        if (gameEnded)
        {
            StopAllCoroutines();
            headData.text = "Sesion Finalizada";
            breathingData.text = "Observaciones:";
            if (cprScript.mesNotDoneCorrectly)
            {
                handsOnData.text = "El procedimiento no ha sido hecho acorde ha faltado reposicionar la cabeza o escuchar la respiracion.";
            }
            else
            {
                handsOnData.text = "Procedimiento completado sin fallas.";
            }
            compressionData.text = "";
            bpmData.text = "Compresiones por minuto: " + cprScript.averageBPM.ToString("F2") + " (Ideal: 100 - 120)";
        }

        StartCoroutine(Tiempo());

        if (Input.GetKeyDown(KeyCode.C))
        {
            gameEnded = true;
        }
    }

    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds(70f);
        gameEnded = true;
    }
}
