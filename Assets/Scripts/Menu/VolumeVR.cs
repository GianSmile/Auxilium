using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VolumeVR : MonoBehaviour
{
    public int volume;
    public TMP_Text text;
    public void plus()
    {
        if(volume < 100)
        {
            volume += 10;
            text.text = volume + "%";
        }
    }

    public void minus()
    {
        if(volume > 0)
        {
            volume -= 10;
            text.text = volume + "%";
        }
    }
}
