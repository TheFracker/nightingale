using UnityEngine;
using System.Collections;

public class Lamps2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "lamps", 1));
	}
	
}