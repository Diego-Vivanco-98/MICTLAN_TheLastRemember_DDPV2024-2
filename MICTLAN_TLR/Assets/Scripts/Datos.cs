using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Datos
{
    public int vidas;
    public int numArmas;
    public int numOro;
    public int numPlata;
    public int porcentajeVida;

    public int GetVidas()
    {
        return vidas;
    }
    public int GetNumArmas() {
        return numArmas;
    }

    public int GetNumOro()
    {
        return numOro;
    }

    public int GetNumPlata()
    {
        return numPlata;
    }

    public int GetPorcentaje()
    {
        return porcentajeVida;
    }

    public void SetVidas(int nVidas)
    {
        vidas = nVidas;
    }

    public void SetArmas(int nArmas)
    {
        numArmas = nArmas;
    }

    public void SetOro(int nOro)
    {
        numOro = nOro;
    }

    public void SetPlata(int nPlata)
    {
        numPlata = nPlata;
    }

    public void SetPorcentajeVida(int pvida)
    {
        porcentajeVida = pvida;
    }
}
