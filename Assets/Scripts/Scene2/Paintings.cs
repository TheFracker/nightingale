using UnityEngine;
using System.Collections;

public class Paintings : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "paintings", 1));
	}
	
}