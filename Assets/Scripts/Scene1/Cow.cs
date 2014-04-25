using UnityEngine;
using System.Collections;

public class Cow  : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "cow", 1));
	}
	
}