using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

	public NameID ID;
	public UnityEvent onMactch;
	
	public void Invoke(NameID id)
	{
		if (ID == id)
		{
			onMactch.Invoke();
		}
	}
}