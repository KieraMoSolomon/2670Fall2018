using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapOn : MonoBehaviour
{

	public FloatData Speed;
	public FloatData HoldTime;
	private Transform parent;
	private bool canRun = true;

	private void OnTriggerEnter(Collider other)
	{
		parent = other.transform;
	}

	public void Call()
	{
		StartCoroutine(MoveTo());
		StartCoroutine(Stop());
	}

	private IEnumerator Stop()
	{
		yield return new WaitForSeconds(HoldTime.Value);
		canRun = false;
	}

	private IEnumerator MoveTo()
	{
		while (canRun)
		{
			yield return new WaitForFixedUpdate();
			transform.position = Vector3.Lerp(transform.position, parent.position, Speed.Value);
		}

		transform.parent = parent;
	}
}
