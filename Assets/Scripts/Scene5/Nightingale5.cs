using UnityEngine;
using System.Collections;

public class Nightingale5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "nightingale", 1));
	}
	
}