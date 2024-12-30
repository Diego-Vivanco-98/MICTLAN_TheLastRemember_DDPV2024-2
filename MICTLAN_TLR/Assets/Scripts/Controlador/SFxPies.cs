using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFxPies : MonoBehaviour
{
    public AudioSource sfxPies;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "terreno")
        {
            sfxPies.Play();
        }
        //prota.puedoSaltar = true;


    }
    
}
