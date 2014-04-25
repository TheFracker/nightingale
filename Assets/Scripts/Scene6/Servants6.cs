using UnityEngine;
using System.Collections;

public class Servants6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "servants", 1));
	}
	
}