using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantBars : MonoBehaviour
{
	public FloatData Seconds;
	//public int ranObj;
	public GameObject[] Bar;
	//public GameObject DontHitBar;
	public Transform transform;

	//public float Seconds = 2.0f;

	public GameObject HitOrNot()
	{
		return Bar[Random.Range(0, 2)];
	}
	
	IEnumerator Start()
	{
		while (true)
		{
			yield return new WaitForSeconds(Seconds.Value);
			{
				Instantiate(HitOrNot(), transform.position, transform.rotation);
			}
		}
	}
}
