using UnityEngine;
using System.Collections;

public class Curtains : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "curtains", ++click));
	}
	
}