using UnityEngine;
using System.Collections;

public class Cow  : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "cow", ++click));
	}
	
}