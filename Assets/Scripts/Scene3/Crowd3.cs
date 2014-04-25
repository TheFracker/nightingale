using UnityEngine;
using System.Collections;

public class Crowd3 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "crowd", ++click));
	}
	
}