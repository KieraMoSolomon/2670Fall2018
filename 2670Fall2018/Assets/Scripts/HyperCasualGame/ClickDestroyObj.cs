using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickDestroyObj : MonoBehaviour
{
	private void OnMouseDown()
	{
		Destroy(gameObject);
	}
}
