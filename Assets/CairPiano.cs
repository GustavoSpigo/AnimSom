using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CairPiano : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("cair");
        }
        
    }
}
