using UnityEngine;
using System.Collections;

public class Nightingale3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "nightingale", 1));
	}
	
}