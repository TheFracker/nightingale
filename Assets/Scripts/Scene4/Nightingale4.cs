using UnityEngine;
using System.Collections;

public class Nightingale4 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "nightingale", 1));
	}
	
}