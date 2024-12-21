using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProta : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidadMovimiento = 10.0f;
    public float velocidadRotacion = 200.0f;

    private Animator anim;
    public float x, y;

    public float fuerzaDeSalto = 8.0f;
    public bool puedoSaltar;


    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }



    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);

        }
        else
        {
            EstoyCayendo();
            //anim.SetBool("salte", true);

        }

    }

    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("tocoSuelo", false);
    }
}
