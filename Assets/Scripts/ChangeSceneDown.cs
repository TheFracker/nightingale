using UnityEngine;
using System.Collections;

public class ChangeSceneDown : MonoBehaviour {

	void OnMouseUpAsButton()
	{
		Application.LoadLevel (Application.loadedLevel - 1);
	}
}
