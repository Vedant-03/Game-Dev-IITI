using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Transform playerPosition;
    public LayerMask groundLayer, playerLayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float sightRange, attackRange;
    public bool inSight, inAttackRange;

    private void Awake()
    {
        playerPosition = GameObject.Find("PlayerArmature").transform;
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        inSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        inAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (!inSight && !inAttackRange)
            Patrol();
        if (inSight && !inAttackRange)
            Chase();
        if (inSight && inAttackRange)
            /*Attack()*/;
    }

    private void Patrol()
    {
        if (!walkPointSet)
            SetWalkPoint();
        if (walkPointSet)
            navAgent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 0.5f)
            walkPointSet = false;
    }

    private void SetWalkPoint()
    {
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        float randomZ = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, groundLayer))
            walkPointSet = true;
    }

    private void Chase()
    {
        navAgent.SetDestination(playerPosition.position);
    }
}
