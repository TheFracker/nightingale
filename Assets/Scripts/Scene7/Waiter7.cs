using UnityEngine;
using System.Collections;

public class Waiter7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "waiter", 1));
	}
	
}