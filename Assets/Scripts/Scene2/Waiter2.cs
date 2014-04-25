using UnityEngine;
using System.Collections;

public class Waiter2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "waiter", 1));
	}
	
}