using UnityEngine;
using System.Collections;

public class Servants1 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "servants", 1));
	}
	
}