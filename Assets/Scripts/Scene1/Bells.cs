using UnityEngine;
using System.Collections;

public class Bells : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene1ClickMessage", "bells", 1));
	}
	
}