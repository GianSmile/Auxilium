using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty grabAnimationAction;
    public Animator handAnimatior;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = grabAnimationAction.action.ReadValue<float>();
        handAnimatior.SetFloat("Grip", triggerValue);
    }
}
