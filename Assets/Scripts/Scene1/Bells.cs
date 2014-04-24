using UnityEngine;
using System.Collections;

public class Bells : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "bells", ++click));
	}
	
}