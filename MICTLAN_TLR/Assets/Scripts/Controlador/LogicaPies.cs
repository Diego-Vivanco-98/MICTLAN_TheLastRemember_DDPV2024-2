using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public PlayerProta prota;
    //public AudioSource SFxCaminar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        prota.puedoSaltar  = true;
       

    }

    private void OnTriggerExit(Collider other)
    {
        prota.puedoSaltar =false;
        //SFxCaminar.Play();
    }
}
