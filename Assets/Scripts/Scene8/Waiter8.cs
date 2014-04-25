using UnityEngine;
using System.Collections;

public class Waiter8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "waiter", 1));
	}
	
}