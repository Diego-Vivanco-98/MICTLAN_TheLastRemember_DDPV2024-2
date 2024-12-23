using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPegaso : MonoBehaviour
{
    
    //-----------------------------------------

    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;

    private Animator anim;
    public float x, y;

    private AnimatorStateInfo playerAnimatorInfo;

    public Rigidbody rb;
    public int fuerzaSalto = 10;
    public bool puedoSaltar;
    public bool tocarSuelo;
    public int fuerzaExtra = 3;

    //public Slider SFxSlider;
    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoGolpe = 10f;

    public bool estoyPateando;


    // Start is called before the first frame update
    void Start()
    {
        //estoyAtacando = false;
        //puedoSaltar = false;
        tocarSuelo = false;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        //Debug.Log("Estoy atacando es: " + estoyAtacando);
        
    }

    private void FixedUpdate()
    {
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);
        }

        //transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
        //transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);

        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoGolpe;
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimatorInfo = anim.GetCurrentAnimatorStateInfo(0);
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        if (Input.GetKeyDown(KeyCode.Return) && tocarSuelo && !estoyAtacando && !estoyPateando)
        {
            anim.SetTrigger("golpeo");
            estoyAtacando = true;
            SoundSFxPegaso.InstanceSFxPegaso.golpeaPegaso();
        }

        if (Input.GetKeyDown(KeyCode.P) && tocarSuelo && !estoyAtacando && !estoyPateando)
        {
            anim.SetTrigger("patear");
            estoyPateando = true;
            SoundSFxPegaso.InstanceSFxPegaso.golpeaPegaso();
        }





        if (tocarSuelo)
        {
            if(!estoyAtacando && !estoyPateando) //Si salto no puedo atacar
            {
                //Debug.Log("Pegaso esta tocando el suelo");
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    anim.SetBool("salto", true);
                    rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
                    SoundSFxPegaso.InstanceSFxPegaso.saltoPegaso();

                }
            }

            anim.SetBool("suelo", true);
        }
        else
        {
            Debug.Log("Pegaso esta cayendo");
            EstoyCayendo();
        }



    }

   
    public void EstoyCayendo()
    {
        rb.AddForce(fuerzaExtra * Physics.gravity);
        anim.SetBool("suelo", false);
        anim.SetBool("salto", false);
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
