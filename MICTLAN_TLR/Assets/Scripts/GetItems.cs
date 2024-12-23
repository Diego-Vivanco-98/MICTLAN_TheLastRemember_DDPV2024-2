using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class GetItems : MonoBehaviour
{
    public TMP_Text OroTexto;
    public TMP_Text BronceTexto;

    public int numeroOro;
    public int numBronce;
    // Start is called before the first frame update
    void start()
    {
 
    }
    void Update()
    {
            OroTexto.text = numeroOro.ToString();   
            BronceTexto.text = numBronce.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="oro")
        {
            Destroy(other.gameObject);
            numeroOro +=1;
            Debug.Log("Número cajas de oro: " + numeroOro);
        }

        if (other.tag == "bronce")
        {
            Destroy(other.gameObject);
            numBronce +=1;
            Debug.Log("Número de cajas de bronce: " + numBronce);



        }
    }
}
