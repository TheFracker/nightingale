using UnityEngine;
using System.Collections;

public class ChangeSceneUp : MonoBehaviour {

	void OnMouseUpAsButton()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
