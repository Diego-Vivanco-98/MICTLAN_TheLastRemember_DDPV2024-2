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

    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoGolpe = 10f;

    public bool estoyPateando;


    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }

        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoGolpe;
        }
    }

    // Update is called once per frame
    void Update()
    {

    
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        if(Input.GetKeyDown(KeyCode.Return) && puedoSaltar && !estoyAtacando && !estoyPateando)
        {
            anim.SetTrigger("golpeo");
            estoyAtacando = true;
        }

        if (Input.GetKeyDown(KeyCode.P) && puedoSaltar && !estoyAtacando && !estoyPateando)
        {
            anim.SetTrigger("patear");
            estoyPateando = true;
            //SoundSFxPegaso.InstanceSFxPegaso.golpeaPegaso();
        }

        if (puedoSaltar)
        {
            if (!estoyAtacando)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {

                    rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
                }
            }

            anim.SetBool("tocoSuelo", true);
            //puedoSaltar=true;

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
        anim.SetBool("salte", false);
    }


    public void DejarGolpear()
    {
        estoyAtacando = false;
        //avanzoSolo = false;
    }

    public void DejarPatear()
    {
        estoyPateando = false;
    }
 

    public void AvanzandoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoAvanzar()
    {
        avanzoSolo = false;
    }
}
