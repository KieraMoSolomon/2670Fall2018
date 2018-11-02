using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantBars : MonoBehaviour
{

	public float Seconds = 2.0f;
	
	IEnumerator CreateBars()
	{
		yield return new WaitForSeconds(Seconds);
	}
}
