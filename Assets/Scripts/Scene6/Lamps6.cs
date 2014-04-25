using UnityEngine;
using System.Collections;

public class Lamps6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "lamps", 1));
	}
	
}