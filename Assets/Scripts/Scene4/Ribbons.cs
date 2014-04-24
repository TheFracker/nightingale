using UnityEngine;
using System.Collections;

public class Ribbons : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "ribbons", ++click));
	}
	
}