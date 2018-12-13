using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{

	public UnityEvent Event;
	// Use this for initialization
	void Start () {
		Event.Invoke();
	}
	
}
