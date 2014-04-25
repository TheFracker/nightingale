using UnityEngine;
using System.Collections;

public class Kaiser7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "kaiser", 1));
	}
	
}