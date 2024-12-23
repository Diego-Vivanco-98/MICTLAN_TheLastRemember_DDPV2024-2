using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicBox : MonoBehaviour
{
    private int contadorOro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.collider.gameObject.tag == "objeto" && hitInfo.collider.gameObject.GetComponent<LogicItems>().destuirConCursor == true)
                {
                    hitInfo.collider.gameObject.GetComponent<LogicItems>().Efecto();
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag =="objeto" && other.GetComponent<LogicItems>().destruirAutomatico == true)
        {
            contadorOro += 1;
            Debug.Log("Cajas de Oro: " + contadorOro);
            other.GetComponent<LogicItems>().Efecto();
            Destroy(other.gameObject);
        }

        if (other.tag == "objeto")
        {
            if(Input.GetMouseButtonDown(1) && other.GetComponent<LogicItems>().destruirAutomatico == false)
            {
                other.GetComponent <LogicItems>().Efecto();
                Destroy(other.gameObject);

            }
        }
    }


}
