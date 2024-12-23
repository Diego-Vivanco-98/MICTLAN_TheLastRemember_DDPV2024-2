using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoot : MonoBehaviour
{

    public PlayerPegaso playerPegaso;

   

    private void OnTriggerStay(Collider other)
    {

        playerPegaso.tocarSuelo= true;
    }

    private void OnTriggerExit(Collider other)  
    {
        playerPegaso.tocarSuelo = false;
    }
}
