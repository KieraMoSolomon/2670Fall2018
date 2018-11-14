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

	IEnumerator Start()
	{
		while (true)
		{

			ranObj = Random.Range(1, 3);
			if (ranObj == 1)
			{
				Instantiate(HitBar);
			}
			else if (ranObj == 2)
			{
				Instantiate(DontHitBar);
			}

			yield return new WaitForSeconds(Seconds.Value);
		}
	}
}
