using UnityEngine;
using System.Collections;

public class Lamps9 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "lamps", 1));
	}
	
}