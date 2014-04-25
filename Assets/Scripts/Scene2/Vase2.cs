using UnityEngine;
using System.Collections;

public class Vase2 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "vases", 1));
	}
	
}