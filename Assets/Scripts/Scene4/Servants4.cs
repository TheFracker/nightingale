using UnityEngine;
using System.Collections;

public class Servants4 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene4ClickMessage", "servants", 1));
	}
	
}