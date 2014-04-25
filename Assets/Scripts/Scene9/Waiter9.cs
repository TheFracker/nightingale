using UnityEngine;
using System.Collections;

public class Waiter9 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "waiter", 1));
	}
	
}