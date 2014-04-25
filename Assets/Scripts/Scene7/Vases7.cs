using UnityEngine;
using System.Collections;

public class Vases7 : MessageBehaviour {
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "vases", 1));
	}
	
}