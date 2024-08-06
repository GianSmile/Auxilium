using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bpmCalculatorScript : MonoBehaviour
{
    private float lastActionTime;
    private float currentActionTime;
    private float timeInterval;
    public TextMeshProUGUI bpmText; // UI Text to display BPM

    void Start()
    {
        lastActionTime = 0f;
        currentActionTime = 0f;
        timeInterval = 0f;
    }

    public void CalculateBPM()
    {
        currentActionTime = Time.time;

        if (lastActionTime != 0)
        {
            timeInterval = currentActionTime - lastActionTime;

            if (timeInterval > 0)
            {
                float bpm = 60f / timeInterval;
                DisplayBPM(bpm);
            }
        }

        lastActionTime = currentActionTime;
    }

    void DisplayBPM(float bpm)
    {
        bpmText.text = "BPM: " + bpm.ToString("F2");
        Debug.Log("BPM: " + bpm.ToString("F2"));
    }
}
