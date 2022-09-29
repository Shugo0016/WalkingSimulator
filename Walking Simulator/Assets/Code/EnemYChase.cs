using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemYChase : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update]
    public float Distance;
    public bool isAngered;
    public NavMeshAgent _agent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if (Distance <= 50)
        {
            isAngered = true;
        }
        if (Distance > 50f)
        {
            isAngered = false;
        }
        if (isAngered)
        {
            _agent.isStopped = false;
            _agent.SetDestination(Player.transform.position);
        }
        if(!isAngered)
        {
            _agent.isStopped = true;
        }
    }
}
