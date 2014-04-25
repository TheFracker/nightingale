using UnityEngine;
using System.Collections;

public class Nightingale8 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "nightingale", ++click));
	}
	
}