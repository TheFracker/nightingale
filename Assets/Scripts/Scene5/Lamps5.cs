using UnityEngine;
using System.Collections;

public class Lamps5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "kaiser", 1));
	}
	
}