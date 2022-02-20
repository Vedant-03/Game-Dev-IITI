using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask GroundLayer, PlayerLayer;

    public Vector3 walkPoint;
    public bool walkPointIsSet;
    public float walkPointRange;

    public float sightRange, attackRange;
    public bool inSightRange, inAttackRange;

    private void Awake()
    {
        player = GameObject.Find("PlayerArmature").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        inSightRange = Physics.CheckSphere(transform.position, sightRange, PlayerLayer);
        inAttackRange = Physics.CheckSphere(transform.position, attackRange, PlayerLayer);

        if(!inSightRange && !inAttackRange)
        {
            Patrol();
        }
        if(inSightRange && !inAttackRange)
        {
            Chase();
        }
        if(inSightRange && inAttackRange)
        {
            /*Attack()*/;
        }
    }
    private void Patrol()
    {
        if(!walkPointIsSet)
        {
            float randomZ = Random.Range(-walkPointRange, walkPointRange);
            float randomX = Random.Range(-walkPointRange, walkPointRange);

            walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
            if(Physics.Raycast(walkPoint, -transform.up, 2f, GroundLayer))
            {
                walkPointIsSet = true;
            }
        }

        if (walkPointIsSet)
        {
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkpoint = transform.position - walkPoint;

        if(distanceToWalkpoint.magnitude < 1f)
        {
            walkPointIsSet = false;
        }
    }

    private void Chase()
    {
        agent.SetDestination(player.position);
    }
}