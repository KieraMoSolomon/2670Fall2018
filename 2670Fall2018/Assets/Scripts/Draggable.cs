using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

	private Vector3 currentPosition;
	private Vector3 newPosition;
	private Camera cam;

	public bool CanDrag;
	
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}

	public IEnumerator OnMouseDown()
	{
		currentPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
		yield return new WaitForFixedUpdate();
		CanDrag = true;
		while (CanDrag)
		{
			yield return new WaitForFixedUpdate();
			newPosition = currentPosition + cam.ScreenToWorldPoint(Input.mousePosition);
			transform.position = newPosition;
		}
	}

	// Update is called once per frame
	private void OnMouseUp()
	{
		CanDrag = false;
	}
}
