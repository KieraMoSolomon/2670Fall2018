using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIAgent : MonoBehaviour
{

	private NavMeshAgent agent;
	private Transform finalDestination;

	public Transform Destination;
	public Transform PostPoint;

	
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		agent.destination = finalDestination.position;
	}


	private void OnTriggerExit(Collider other)
	{
		finalDestination = PostPoint;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == Destination)
		{
			finalDestination = Destination;
		}
	}
}
