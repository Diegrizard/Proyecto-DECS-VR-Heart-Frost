using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public Animator animator;
    public GameObject jumpScare;
    [SerializeField] private GameObject chest;
    
    private void OnTriggerEnter(Collider other)
    {
        
        
        animator.SetBool("TriggerEnter", true);
        jumpScare.SetActive(true);
    }

  
}
