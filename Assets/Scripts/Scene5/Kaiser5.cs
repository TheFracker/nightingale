using UnityEngine;
using System.Collections;

public class Kaiser5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "kaiser", 1));
	}
	
}