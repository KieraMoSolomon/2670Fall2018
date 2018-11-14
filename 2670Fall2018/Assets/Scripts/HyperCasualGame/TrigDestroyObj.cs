using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigDestroyObj : MonoBehaviour {
	
	private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
	}
}
