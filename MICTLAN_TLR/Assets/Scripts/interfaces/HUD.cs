using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class HUD : MonoBehaviour
{
    public GameObject panelHUD;
    public TextMeshProUGUI vidasText;
    public TextMeshProUGUI recuerdosText;
    public TextMeshProUGUI puntosVidaText;
    public TextMeshProUGUI numMunicionesText;
    public TextMeshProUGUI porcentajeVida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNumMuniciones(int municiones)
    {
        numMunicionesText.text = "x" + municiones.ToString();
        //armas.text = datos.GetNumArmas().ToString();
    }

    public void SetNumPuntosVida(float puntosVida)
    {
        puntosVidaText.text = "x" + puntosVida.ToString();
    }

    public void SetNumRecuerdos(int numRecuerdos)
    {
        recuerdosText.text = numRecuerdos.ToString();
    }

    public void GetNumVidas(int numVidas)
    {
        vidasText.text = numVidas.ToString();
    }
}
