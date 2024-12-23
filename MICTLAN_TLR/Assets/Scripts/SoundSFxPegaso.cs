using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundSFxPegaso : MonoBehaviour
{
    public AudioSource SFxPegasoSource;

    public AudioClip[] SFxClip;

    public static SoundSFxPegaso InstanceSFxPegaso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        InstanceSFxPegaso = this;
    }

    public void caminaPegaso()
    {
        SFxPegasoSource.PlayOneShot(SFxClip[0]);
    }

    public void saltoPegaso()
    {
        SFxPegasoSource.PlayOneShot(SFxClip[1]);
    }

    public void impactaSueloPegaso()
    {
        SFxPegasoSource.PlayOneShot(SFxClip[2]);
    }

    public void golpeaPegaso()
    {
        SFxPegasoSource.PlayOneShot(SFxClip[3]);
    }
    public void pateaPegaso()
    {
        SFxPegasoSource.PlayOneShot(SFxClip[4]);
    }

}
