using UnityEngine;
using System.Collections;

public class Crowd7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "crowd", 1));
	}
	
}