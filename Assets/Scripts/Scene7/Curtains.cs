using UnityEngine;
using System.Collections;

public class Curtains : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "curtains", 1));
	}
	
}