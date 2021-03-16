using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorPorta : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("aberto", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("aberto", false);
        }
    }
}
