using UnityEngine;
using System.Collections;

public class Nightingale1 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "nightingale", ++click));
	}
	
}