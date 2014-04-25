using UnityEngine;
using System.Collections;

public class Vases3 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "vases", ++click));
	}
	
}