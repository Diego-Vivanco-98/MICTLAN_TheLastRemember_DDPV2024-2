using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSFxMuerto : MonoBehaviour
{
    public AudioSource SFxMuertoSource;

    public AudioClip[] SFxMClip;

    public static SoundSFxMuerto InstanceSFxMuerto;
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
        InstanceSFxMuerto = this;
    }

    public void atacaMuerto()
    {
        SFxMuertoSource.PlayOneShot(SFxMClip[0]);
        //SFxPegasoSource.PlayOneShot(SFxClip[3]);
    }


}
