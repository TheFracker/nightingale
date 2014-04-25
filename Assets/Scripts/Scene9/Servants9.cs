using UnityEngine;
using System.Collections;

public class Servants9 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "servants", 1));
	}
	
}