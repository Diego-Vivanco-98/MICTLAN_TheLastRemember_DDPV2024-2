using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public int ID;
    public string type;
    public string descripcion;
    public Sprite icono;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equipado;

    [HideInInspector]
    public GameObject armas;

    [HideInInspector]
    public GameObject arma;

    public bool playerArma;



    // Start is called before the first frame update
    private void Start()
    {
        armas = GameObject.FindWithTag("Armas");
        //Debug.LogError("No se encontró un objeto con el tag 'Armas'.");
        if (armas == null)
        {
            Debug.LogError("No se encontró un objeto con el tag 'Armas'.");
            return;
        }
        if (!playerArma)
        {
            int numArmas = armas.transform.childCount;
            Debug.Log("Numero de Armas" + numArmas);

            for(int i=0; i < numArmas; i++)
            {
                if (armas.transform.GetChild(i).gameObject.GetComponent<Item>().ID == ID)
                {
                    Debug.Log("Encontro una coincidencia");
                    arma = armas.transform.GetChild(i).gameObject;
                }

            }

        }
        }

    // Update is called once per frame
    private void Update()
    {
        if (equipado)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                equipado = false;
            }
            if (!equipado)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void ItemUsage()
    {
        if (type == "Hacha")
        {
            arma.SetActive(true);
            arma.GetComponent<Item>().equipado = true;
        }
    }


}
