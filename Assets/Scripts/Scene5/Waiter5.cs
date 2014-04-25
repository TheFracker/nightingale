using UnityEngine;
using System.Collections;

public class Waiter5 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "waiter", ++click));
	}
	
}