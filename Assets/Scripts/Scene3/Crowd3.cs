using UnityEngine;
using System.Collections;

public class Crowd3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "crowd", 1));
	}
	
}