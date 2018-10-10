using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

	public NameID ID;
	public UnityEvent onMactch;

	private void OnTriggerEnter(Collider other)
	{
		var id = other.GetComponent<ObjectID>().ID;
		Call(id);
	}

	public void Call(NameID id)
	{
		if (ID == id)
		{
			onMactch.Invoke();
		}
	}
}