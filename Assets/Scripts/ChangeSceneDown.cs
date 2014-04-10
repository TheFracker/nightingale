using UnityEngine;
using System.Collections;

public class ChangeSceneDown : MonoBehaviour {
	public int LevelToLoad;
	void OnMouseUpAsButton()
	{
		Debug.Log(Application.loadedLevel);

		Application.LoadLevel (LevelToLoad);
	}
}