using UnityEngine;
using System.Collections;

public class Kaiser9 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "kaiser", ++click));
	}
	
}