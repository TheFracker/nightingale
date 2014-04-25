using UnityEngine;
using System.Collections;

public class Waiter1 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "waiter", 1));
	}
	
}