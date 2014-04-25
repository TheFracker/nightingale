using UnityEngine;
using System.Collections;

public class Kaiser8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "kaiser", 1));
	}
	
}