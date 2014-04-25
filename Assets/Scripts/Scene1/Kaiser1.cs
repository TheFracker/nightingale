using UnityEngine;
using System.Collections;

public class Kaiser1 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "kaiser", ++click));
	}
	
}