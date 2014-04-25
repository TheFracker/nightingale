using UnityEngine;
using System.Collections;

public class Nightingale8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "nightingale", 1));
	}
	
}