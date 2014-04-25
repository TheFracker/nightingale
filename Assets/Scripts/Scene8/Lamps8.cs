using UnityEngine;
using System.Collections;

public class Lamps8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "lamps", 1));
	}
	
}