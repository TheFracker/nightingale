using UnityEngine;
using System.Collections;

public class Servants9 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "servants", ++click));
	}
	
}