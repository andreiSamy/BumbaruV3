using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Animator elevator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            elevator.SetTrigger("UP");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            elevator.SetTrigger("Down");
        }
    }
}
