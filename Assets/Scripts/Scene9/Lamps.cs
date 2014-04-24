using UnityEngine;
using System.Collections;

public class Lamps : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "lamps", ++click));
	}
	
}