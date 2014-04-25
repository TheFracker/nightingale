using UnityEngine;
using System.Collections;

public class Servants2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "servants", 1));
	}
	
}