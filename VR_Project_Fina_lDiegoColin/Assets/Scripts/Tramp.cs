using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour
{
    public Animator animator;

    public void AnimationFloor()
    {
        animator.SetBool("Grab", true);
    }
}
