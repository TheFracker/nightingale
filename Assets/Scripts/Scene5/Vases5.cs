using UnityEngine;
using System.Collections;

public class Vases5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "vases", 1));
	}
	
}