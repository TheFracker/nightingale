using UnityEngine;
using System.Collections;

public class Crowd : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "crowd", ++click));
	}
	
}