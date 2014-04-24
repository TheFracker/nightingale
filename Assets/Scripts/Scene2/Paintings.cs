using UnityEngine;
using System.Collections;

public class Paintings : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "paintings", ++click));
	}
	
}