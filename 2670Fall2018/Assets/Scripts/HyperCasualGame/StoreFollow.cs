using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StoreFollow : ScriptableObject
{

	public List<Object> Skins;
	public int ItemValue;
	public List<Object> Purchased;
	public IntData Cash;
	public IntData playerPick;
	
	public void Purchase()
	{
		if (Cash.value >= ItemValue)
		{
			Cash.value -= ItemValue;
		}
	}

	
}
