using UnityEngine;
using System.Collections;

public class Waiter3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "waiter", 1));
	}
	
}