using UnityEngine;
using System.Collections;

public class Vases3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "vases", 1));
	}
	
}