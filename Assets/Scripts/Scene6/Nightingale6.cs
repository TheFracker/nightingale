using UnityEngine;
using System.Collections;

public class Nightingale6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "nightingale", 1));
	}
	
}