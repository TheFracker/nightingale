using UnityEngine;
using System.Collections;

public class Kaiser3 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene3ClickMessage", "kaiser", 1));
	}
	
}