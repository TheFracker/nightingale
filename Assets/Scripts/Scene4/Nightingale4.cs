using UnityEngine;
using System.Collections;

public class Nightingale4 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "nightingale", ++click));
	}
	
}