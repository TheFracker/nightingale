using UnityEngine;
using System.Collections;

public class Butterfly : MessageBehaviour {

	int click = 0;

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "butterfly", ++click));
	}

}