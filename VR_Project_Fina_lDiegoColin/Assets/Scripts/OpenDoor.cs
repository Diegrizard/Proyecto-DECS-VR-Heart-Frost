using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private GameObject door;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Key")
        {
            animator.SetBool("Open", true);
        }
       
    }

    public void AnimationDoor()
    {
        animator.SetBool("Open", true);
    }

    public void AnimationFloor()
    {
        animator.SetBool("Grab", true);
    }

}
