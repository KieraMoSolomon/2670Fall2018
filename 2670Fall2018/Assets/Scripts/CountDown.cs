using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	
	public int number = 3;
	private Text label;
	
	// Use this for initialization
	IEnumerator Start ()
	{
		label = GetComponent<Text>();


		while (number > 0)
		{
			yield return new WaitForSeconds(1);
			label.text = number.ToString();
			number--;
		}

		label.text = "";
		yield return new WaitForSeconds(1);
		label.text = "GO!";
	}
	
}
