using UnityEngine;
using System.Collections;

public class Lamps3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "lamps", 1));
	}
	
}