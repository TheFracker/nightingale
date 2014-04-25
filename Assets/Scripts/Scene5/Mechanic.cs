using UnityEngine;
using System.Collections;

public class Mechanic : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "mechanic", 1));
	}
	
}