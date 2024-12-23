using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Caida : MonoBehaviour
{
    public int lifes = 3;
    public int cont = 0;
    public LogicaBarraVida barra;

    public TMP_Text lifesTexto;

    public GameObject personaje;
    public Transform puntoInicial;
    public PauseMenu pausaCanvas;

    // Start is called before the first frame update


    private void Update()
    {
        lifesTexto.text = lifes.ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "vacio")
        {

            lifes -= 1;
            MoverPuntoInicial();
            barra.vidaActual = barra.vidaMax;

            checaVida();

        }

    }

    public void checaVida()
    {
        if (lifes <= 0)
        { 
            pausaCanvas.HUD.SetActive(false);
            pausaCanvas.GameOver.SetActive(true);
           
        }
    }

    public void MoverPuntoInicial()
    {
        personaje.transform.position = puntoInicial.position;
    }

    }

