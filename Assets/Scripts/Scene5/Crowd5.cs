using UnityEngine;
using System.Collections;

public class Crowd5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "crowd", 1));
	}
	
}