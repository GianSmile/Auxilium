using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public string[] texts;
    public bool[] skipables;
    int i = -1;
    private TMP_Text tutorialText;
    public bool isVR;
    public GameObject skipE, skipTrigger;

    private void Start()
    {
        tutorialText = GameObject.FindGameObjectWithTag("Tutorial").GetComponent <TMP_Text>();
        Change();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && skipables[i] == true)
        {
            Change();
        }
    }

    void Change()
    {
        i++;
        if(i >= texts.Length){
            Destroy(gameObject);
            return;
        }
        if(skipables[i] == true){
            if(!isVR) skipE.SetActive(true);
            else skipTrigger.SetActive(true);
        }
        if(skipables[i] == false){
            if(!isVR) skipE.SetActive(false);
            else skipTrigger.SetActive(false);
        }
        tutorialText.text = texts[i];
    }
}
