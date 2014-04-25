using UnityEngine;
using System.Collections;

public class Kaiser2 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "kaiser", ++click));
	}
	
}