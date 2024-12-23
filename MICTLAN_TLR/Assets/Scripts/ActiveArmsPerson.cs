using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveArmsPerson : MonoBehaviour
{
    public LoadArms tomarArma;
    public int numArma;
    //private int contadorArmas;

    // Start is called before the first frame update
    void Start()
    {
        tomarArma = GameObject.FindGameObjectWithTag("Pegaso").GetComponent<LoadArms>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pegaso"))
        {
            //contadorArmas = contadorArmas + 1;
            tomarArma.activaArmas(numArma);
            Destroy(gameObject);
            //Debug.Log("Cantidad Armas: " + contadorArmas);
        }
    }


}
