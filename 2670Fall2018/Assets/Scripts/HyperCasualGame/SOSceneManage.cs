using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SOSceneManage : ScriptableObject
{

	public int SceneIndex;

	public void Call()
	{
		SceneManager.LoadScene(SceneIndex);
	}
}
