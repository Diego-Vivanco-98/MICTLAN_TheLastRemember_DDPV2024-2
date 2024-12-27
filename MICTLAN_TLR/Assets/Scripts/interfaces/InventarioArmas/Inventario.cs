using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    private bool activarInventario;
    public GameObject inventario;
    private int numSlots;
    private int activarSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    // Start is called before the first frame update
    void Start()
    { 
        numSlots = slotHolder.transform.childCount;
        slot = new GameObject[numSlots];

        for(int i=0; i < numSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activarInventario = !activarInventario;

        }
        if (activarInventario)
        {
            inventario.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            inventario.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
