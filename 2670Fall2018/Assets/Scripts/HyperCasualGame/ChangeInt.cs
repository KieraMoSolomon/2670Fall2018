using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ChangeInt : ScriptableObject {

	public int Int;

	public void Call(IntData intData)
	{
		intData.value = Int;
	}
}
