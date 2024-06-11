using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactableObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = rightAttachTransform;
            Debug.Log("R");
        }

        if(args.interactorObject.transform.CompareTag("Left Hand"))
        {
            secondaryAttachTransform = leftAttachTransform;
            Debug.Log("L");
        }

        base.OnSelectEntered(args);
    }
}
