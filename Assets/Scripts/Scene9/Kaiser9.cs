using UnityEngine;
using System.Collections;

public class Kaiser9 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "kaiser", 1));
	}
	
}