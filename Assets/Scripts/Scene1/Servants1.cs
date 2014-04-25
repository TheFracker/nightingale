using UnityEngine;
using System.Collections;

public class Servants1 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "servants", ++click));
	}
	
}