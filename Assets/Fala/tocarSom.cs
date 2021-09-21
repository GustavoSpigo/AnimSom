using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarSom : MonoBehaviour
{
    private AudioSource MeuAudio;
    void Start()
    {
        MeuAudio = GetComponent<AudioSource>();
    }

    public void FalaMeuFi()
    {
        MeuAudio.Play();
    }
}
