using UnityEngine;
using UnityEngine.Events;

public class TriggerID : MonoBehaviour
{

	public NameID ID;
	public UnityEvent onMactch;
	
	private void OnTriggerEnter(Collider obj)
	{
		if (ID == obj.GetComponent<ObjectID>().ID)
		{
			onMactch.Invoke();
			print("Match");
		}
	}
}
