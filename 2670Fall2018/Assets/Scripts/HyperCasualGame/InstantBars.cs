using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantBars : MonoBehaviour
{
	public FloatData Seconds;
	public int ranObj;
	public GameObject HitBar;
	public GameObject DontHitBar;

	//public float Seconds = 2.0f;
	
	IEnumerator CreateBars()
	{
		yield return new WaitForSeconds(Seconds.Value);
		/*ranObj = Random.Range(1, 2);
		if (ranObj == 1)
		{
			Instantiate(HitBar);
		}
		else
		{
			Instantiate(DontHitBar);
		}*/
	}
}
