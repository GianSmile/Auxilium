using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public string[] texts;
    int i = 0;
    private TMP_Text tutorialText;

    private void Start()
    {
        tutorialText = GameObject.FindGameObjectWithTag("Tutorial").GetComponent <TMP_Text>();
        Change();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            i++;
            Change();
        }
    }

    void Change()
    {
        tutorialText.text = texts[i];
    }
}
