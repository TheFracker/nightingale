using UnityEngine;
using System.Collections;

public class Lamps4 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "lamps", 1));
	}
	
}