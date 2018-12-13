using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectCoins : MonoBehaviour
{

	public UnityEvent Event;
	public IntData coins;
	public IntData cost;

	public void GetCoins()
	{
		coins.value += coins.value;
	}

}
