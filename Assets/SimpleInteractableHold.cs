using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SimpleInteractableHold : XRGrabInteractableTwoAttach
{
    //Hold on transforms to hands then check where they are in the Z axis? since it will loop use ifs (remember using loops inside loops will crash stupid) check inside a range and figure a way to check also frecuency
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
    }
}
