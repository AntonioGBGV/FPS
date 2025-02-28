using UnityEngine;
using UnityEngine.AI;

public class EnemyMovimiento : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (objetivo != null)
        {
            navMeshAgent.SetDestination(objetivo.position);
        }
    }
}
