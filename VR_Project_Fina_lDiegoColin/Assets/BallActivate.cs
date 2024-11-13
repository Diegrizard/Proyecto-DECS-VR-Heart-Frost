using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallActivate : MonoBehaviour
{
    [SerializeField] GameObject bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bola.SetActive(true);
        }
    }
}
