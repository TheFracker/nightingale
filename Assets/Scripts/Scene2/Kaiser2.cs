using UnityEngine;
using System.Collections;

public class Kaiser2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "kaiser", 1));
	}
	
}