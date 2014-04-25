using UnityEngine;
using System.Collections;

public class Vases8 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene8ClickMessage", "vases", 1));
	}
	
}