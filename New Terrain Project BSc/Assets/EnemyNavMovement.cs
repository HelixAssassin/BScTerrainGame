using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNavMovement : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agent;
    public Transform target;

	// Use this for initialization
	void Start ()
    {
        //This allows the enemy to move towards the player
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //This tells the enemy to use the NavMesh attached to the terrain
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
        if(agent.remainingDistance<(agent.stoppingDistance + 0.5f))
        {
            transform.LookAt(target.transform);
        }
		
	}
}