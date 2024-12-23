using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadArms : MonoBehaviour
{


    public GameObject interfazHUD;

    public TextMeshProUGUI armasRecolectadas;
    //public TextMeshProUGUI cajasOro;
    //public TextMeshProUGUI cajasBronce;

    public GameObject[] armas;
    private int contadorArmas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            desactivaArmas();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal" && contadorArmas == 3)
        {
            SceneManager.LoadScene(2);
        }
        if (other.tag == "Portal2" && contadorArmas == 3)
        {
            SceneManager.LoadScene(3);
        }
        if (other.tag == "Portal3" && contadorArmas == 3)
        {
            SceneManager.LoadScene(4);
        }
        if (other.tag == "armadura" && contadorArmas == 3)
        {
            //SceneManager.LoadScene(4);
            SceneManager.LoadScene(5);
            Debug.Log("GANASTE EL JEUGO");
        }

    }

    public void activaArmas(int numero)
    {
        for(int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
        contadorArmas = contadorArmas + 1;
        SetArmas(contadorArmas);
    }

    public void desactivaArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }
    public void SetArmas(int numeroArmas)
    {
        armasRecolectadas.text = numeroArmas.ToString();
    }
}
