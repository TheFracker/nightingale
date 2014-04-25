using UnityEngine;
using System.Collections;

public class Vases7 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "vases", ++click));
	}
	
}