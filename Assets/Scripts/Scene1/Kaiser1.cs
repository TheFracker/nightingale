using UnityEngine;
using System.Collections;

public class Kaiser1 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "kaiser", 1));
	}
	
}