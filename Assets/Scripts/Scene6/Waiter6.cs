using UnityEngine;
using System.Collections;

public class Waiter6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "waiter", 1));
	}
	
}