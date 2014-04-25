using UnityEngine;
using System.Collections;

public class Lamps7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "lamps", 1));
	}
	
}