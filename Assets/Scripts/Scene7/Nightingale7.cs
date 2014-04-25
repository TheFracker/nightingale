using UnityEngine;
using System.Collections;

public class Nightingale7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "nightingale", 1));
	}
	
}