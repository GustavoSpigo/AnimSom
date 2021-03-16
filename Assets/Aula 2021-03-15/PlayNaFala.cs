using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNaFala : MonoBehaviour
{
    public AudioSource SomQueVaiTocar;
    public void DaPlayNoBaguio()
    {
        if (SomQueVaiTocar.isPlaying)
        {
            SomQueVaiTocar.Stop();
        }
        SomQueVaiTocar.Play();
    }
}
