using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] wappoints;
    private int m_CurrentWaypointIndex;
    
    void Start()
    {
        navMeshAgent.SetDestination(wappoints[0].position);
    }

    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % wappoints.Length;
            navMeshAgent.SetDestination(wappoints[m_CurrentWaypointIndex].position);
        }
    }
}
