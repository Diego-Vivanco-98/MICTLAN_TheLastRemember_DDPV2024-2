using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerEnemigo : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent navMeshAgent;
    private Transform playerTransform;
    private Vector3 playerPosition;

    public float waitToPatrol;

    public Vector2 destinationArea;
    private EnemyState currentState;
    private Vector3 patrolDestination = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Prota").transform;
        changeState(EnemyState.PATROL); //Primero va a patrullar
    }

    private void changeState(EnemyState newState)
    {
        switch (newState)
        {
            case EnemyState.PATROL:
                currentState = newState;
                StartCoroutine("GeneratePatrolDestination");
                break;
            case EnemyState.CHASE:
                if(currentState == EnemyState.PATROL)
                {
                    StopCoroutine("GeneratePatrolDestination");
                }
                break;
            case EnemyState.ATTACK:
                break;
            case EnemyState.DEATH:
                break;
        }
    }
/*
    public IEnumerator GeneratePatrolDestination()
    {
        while (true)
        {
            patrolDestination = transform.position + new Vector3(Random.Range(-destinationArea.x, destinationArea.y),0 , Random.Range(-destinationArea.x, destinationArea.y));
            navMeshAgent.SetDestination(playerTransform.position);
            yield return new WaitForSecondsRealTime(waitToPatrol);

        }
    } */

    // Update is called once per frame
    void Update()
    {
        //navMeshAgent.SetDestination(playerTransform.position);
        animator.SetFloat("velY", navMeshAgent.velocity.sqrMagnitude);
    }
}

public enum EnemyState
{
    PATROL,
    ATTACK,
    CHASE,
    DEATH
}

