using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragao : MonoBehaviour
{
    private Animator anim;
    public AudioSource AudioPeDir, AudioPeEsq;

    public AudioSource AudioNaruto;

    public Material parede;
    public Transform parede2;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Atualiza o parâmetro de movimento do Animator
        anim.SetFloat("movimentacao", Input.GetAxisRaw("Horizontal"));

        //Se está movimentando não importa o lado
        if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.1f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * (Input.GetAxisRaw("Horizontal") > 0 ? -1 : 1),
                                               transform.localScale.y,
                                               transform.localScale.z);
            if (!AudioNaruto.isPlaying)
            {
                AudioNaruto.Play();
            }
        }
        else
        {
            AudioNaruto.Stop();
        }
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.1f)
        {
            parede2.rotation = new Quaternion(parede2.rotation.x,
                                             parede2.rotation.y + 0.01f * (Input.GetAxisRaw("Horizontal") > 0 ? 1 : -1),
                                             parede2.rotation.z,
                                             parede2.rotation.w);

        parede.mainTextureOffset = new Vector2(parede.mainTextureOffset.x + 0.01f * (Input.GetAxisRaw("Horizontal") > 0 ? -1 : 1),
                                               parede.mainTextureOffset.y);

        }
    }

    public void TocarPeDir()
    {
        AudioPeDir.volume = Random.Range(0.9f, 1f);
        AudioPeDir.pitch = Random.Range(0.95f, 1.05f);
        AudioPeDir.Play();
    }
    public void TocarPeEsq()
    {
        AudioPeEsq.volume = Random.Range(0.9f, 1f);
        AudioPeEsq.pitch = Random.Range(0.95f, 1.05f);
        AudioPeEsq.Play();
    }
}
