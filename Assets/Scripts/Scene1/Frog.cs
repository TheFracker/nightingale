using UnityEngine;
using System.Collections;

public class Frog : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "frog", ++click));
	}
	
}