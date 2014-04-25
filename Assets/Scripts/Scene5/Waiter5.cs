using UnityEngine;
using System.Collections;

public class Waiter5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "waiter", 1));
	}
	
}