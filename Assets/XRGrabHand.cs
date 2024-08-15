using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabHand : XRGrabInteractable
{
    public GameObject lHandModel;
    

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Left Hand"))
        {
            lHandModel.transform.position = GameObject.Find("Right Hand").GetComponent<Transform>().position;
            base.OnSelectEntered(args);
        }
    }
}
