using UnityEngine;
using System.Collections;

public class Lamps6 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "lamps", ++click));
	}
	
}