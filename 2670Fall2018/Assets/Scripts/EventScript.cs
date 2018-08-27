using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour {

	 public UnityEvent MyEvent;

	private void OnMouseDown()
	{
		MyEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		MyEvent.Invoke();
	}
}
