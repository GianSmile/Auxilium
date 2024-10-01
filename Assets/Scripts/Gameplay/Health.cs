using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private Slider slider;
    void Start()
    {
        slider = this.gameObject.GetComponent<Slider>();
        slider.value = 100;
        StartCoroutine(Lose(0.5f));
    }

    public void Gain(int value)
    {
        slider.value += value;
        if(slider.value > 100)
        {
            slider.value = 100;
        }
    }

    IEnumerator Lose(float cooldown)
    {
        if(slider.value <= 0)
        {
            Debug.Log("Muereeeee");
        }
        else
        {
            yield return new WaitForSeconds(cooldown);
            slider.value--;
            StartCoroutine(Lose(0.5f));
        }
        
    }
}
