using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageSound : MonoBehaviour
{
    public AudioSource tocadorDeSom;
    public AudioClip somIaaawww;
    public AudioClip somPim;
    public void TocarIaaawww()
    {
        tocadorDeSom.Stop();
        tocadorDeSom.clip = somIaaawww;
        tocadorDeSom.volume = 1;
        tocadorDeSom.Play();
    }
    public void TocarPim(float Volume)
    {
        tocadorDeSom.Stop();
        tocadorDeSom.clip = somPim;
        tocadorDeSom.volume = Volume;
        tocadorDeSom.Play();
    }
}
