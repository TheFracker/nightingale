using UnityEngine;
using System.Collections;

public class Ribbons : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "ribbons", 1));
	}
	
}