using UnityEngine;
using System.Collections;

public class Lamps4 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "lamps", ++click));
	}
	
}