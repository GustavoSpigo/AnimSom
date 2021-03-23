using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaTrigger : MonoBehaviour
{
    public string TagQueAtivaTrigger;
    public string NomeDaTrigger;
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagQueAtivaTrigger))
        {
            anim.SetTrigger(NomeDaTrigger);
        }
    }
}
