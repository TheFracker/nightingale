using UnityEngine;
using System.Collections;

public class Crowd7 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "crowd", ++click));
	}
	
}