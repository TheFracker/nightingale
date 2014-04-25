using UnityEngine;
using System.Collections;

public class Flowers : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "flowers", 1));
	}
	
}