using UnityEngine;
using System.Collections;

public class Crowd8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "crowd", 1));
	}
	
}