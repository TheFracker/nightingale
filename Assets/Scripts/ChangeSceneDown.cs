using UnityEngine;
using System.Collections;

public class ChangeSceneDown : MonoBehaviour {

	void OnMouseUpAsButton()
	{
		Debug.Log(Application.loadedLevel);

		if (Application.loadedLevel == 2)
			Application.LoadLevel(1);
		Application.LoadLevel (Application.loadedLevel - 1);


	}
}
