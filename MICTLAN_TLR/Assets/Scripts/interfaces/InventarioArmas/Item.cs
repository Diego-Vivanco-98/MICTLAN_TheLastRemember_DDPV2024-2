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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
