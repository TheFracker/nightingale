using UnityEngine;
using System.Collections;

public class Butterfly : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "butterfly", 1));
	}

}