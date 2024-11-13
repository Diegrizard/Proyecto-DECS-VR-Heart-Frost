using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationManager : MonoBehaviour
{
    public InputActionProperty Dedos_AnimationAction;
    public InputActionProperty Agarre_AnimationAction;

    public Animator handAnimator;




    void Update()
    {

        float triggerValue = Dedos_AnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = Agarre_AnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);


    }
}
