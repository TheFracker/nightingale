using UnityEngine;
using System.Collections;

public class Nightingale2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "nightingale", 1));
	}
	
}