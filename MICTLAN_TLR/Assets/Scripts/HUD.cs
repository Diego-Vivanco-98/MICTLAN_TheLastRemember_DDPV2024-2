using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class HUD : MonoBehaviour
{
    public string fileName;
    private StreamWriter sw;
    private StreamReader sr;
    private string fileContent;
    private Datos datos;

    public GameObject panelHUD;

    public TextMeshProUGUI vidas;
    public TextMeshProUGUI armas;
    public TextMeshProUGUI cajasOro;
    public TextMeshProUGUI cajasBronce;
    public TextMeshProUGUI porcentajerVida;





    // Start is called before the first frame update
    void Start()
    {
        //ruta = Application.persistentDataPath + "/" + fileName;
        if (File.Exists(/*(Application.persistentDataPath + "/" + */fileName))
        {
            Debug.Log("El archivo ya existe");
            sr = new StreamReader(/*Application.persistentDataPath + "/" +*/ fileName);
            Debug.Log(Application.persistentDataPath + "/" + fileName);
            fileContent = sr.ReadToEnd();
            //Debug.Log("File Content" + fileContent);
            datos = new Datos();
            datos = JsonUtility.FromJson<Datos>(fileContent);
            Debug.Log(datos.numArmas);
        }
        else
        {
            Debug.Log("No existe el archivo");
            datos = new Datos();
            datos.vidas = 3;
            datos.numArmas = 0;
            datos.numPlata = 0;
            datos.numOro = 0;
            datos.porcentajeVida = 100;

            Debug.Log("Se creo el archivo");

        }

        showHUD();

    }

    // Update is called once per frame
    void Update()
    {
        //GetNumArmas();
    }

    public void showHUD()
    {
        GetNumArmas();
    }
    public void GetNumArmas()
    {
        armas.text = datos.GetNumArmas().ToString();
    }

    public void GetOro()
    {
        cajasOro.text = datos.numOro.ToString();
    }

    public void GetPlata()
    {
        cajasBronce.text = datos.numPlata.ToString();
    }

    public void GetNumVidas()
    {
        vidas.text = datos.vidas.ToString();
    }

}
