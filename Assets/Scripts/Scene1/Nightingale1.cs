using UnityEngine;
using System.Collections;

public class Nightingale1 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "nightingale", 1));
	}
	
}