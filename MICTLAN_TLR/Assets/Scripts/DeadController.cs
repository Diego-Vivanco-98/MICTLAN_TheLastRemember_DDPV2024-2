using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DeadController : MonoBehaviour
{

    public int rutina;
    public float cronometro;
    public Animator animator;
    public Quaternion angulo;
    public float grado;
    public int vidaM = 100;
    public bool atacar;

    public GameObject target;
    private int contGolpes;

    //public NavMeshAgent agente;
    public float distancia_ataque;
    public float radio_vision;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.Find("Pegaso");
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento();
    }

    public void Comportamiento()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 20)
        {
            //agente.enabled = false;
            animator.SetBool("walk", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }

            switch (rutina)
            {
                case 0:
                    animator.SetBool("walk", false);

                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    animator.SetBool("walk", true);
                    break;
            }
        }
        else
        {
            //var lookPos = target.transform.position - transform.position;
            //lookPos.y = 0;
            //var rotation = Quaternion.LookRotation(lookPos);
            //agente.enabled = true;
            //agente.SetDestination(target.transform.position);
            //if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacar)
            //{
            //    animator.SetBool("walk", false);
            //    animator.SetBool("run", true);
            //}
            //else
            //{
            //    if (!atacar)
            //    {
            //        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 1);
            //        animator.SetBool("walk", false);
            //        animator.SetBool("run", false);
            //    }

            //}



            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacar)
            {
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
                animator.SetBool("walk", false);
                animator.SetBool("run", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                animator.SetBool("attack", false);
            }
            else
            {
                animator.SetBool("walk", false);
                animator.SetBool("run", false);
                animator.SetBool("attack", true);
                SoundSFxMuerto.InstanceSFxMuerto.atacaMuerto();
                atacar = true;
            }
        }

        //if(atacar)
        //{
        //    agente.enabled = false;
        //}
    }

    public void Fin_anim()
    {
        //if(Vector3.Distance(transform.position, target.transform.position) > distancia_ataque + 0.2f)
        //{
        //    animator.SetBool("attack", false);
        //}
        animator.SetBool("attack", false);
        atacar = false;
    }



    private void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("ataque") || coll.CompareTag("patada"))
        {
            contGolpes++;
            if(contGolpes > 5)
            {
                Destroy(gameObject);
            }
        }
    }
}
