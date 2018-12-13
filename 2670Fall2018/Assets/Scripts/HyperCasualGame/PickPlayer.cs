using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPlayer : MonoBehaviour
{

	public Objects PlayerList;

	public IntData playerPick;
	
	// Use this for initialization
	void Start ()
	{
		Instantiate(PlayerList.ObjectList[playerPick.value]);
	}
	
}
