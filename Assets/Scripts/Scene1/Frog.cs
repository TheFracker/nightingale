using UnityEngine;
using System.Collections;

public class Frog : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "frog", 1));
	}
	
}