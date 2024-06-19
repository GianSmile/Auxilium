using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SimpleInteractableHold : XRGrabInteractableTwoAttach
{
    //Hold on call script
    public GameObject ControllerL;
    public GameObject ControllerR;

    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

    private void Start()
    {
        ControllerL = GameObject.Find("Left Hand");
        ControllerR = GameObject.Find("Right Hand");
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = rightAttachTransform;
            Debug.Log("R");
        }

        else if (args.interactorObject.transform.CompareTag("Left Hand"))
        {
            attachTransform = leftAttachTransform;
            //ControllerL.GetComponent<XRController>().
            Debug.Log("L");
        }
        base.OnSelectEntered(args);
    }
}
