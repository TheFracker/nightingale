using UnityEngine;
using System.Collections;

public class Kaiser6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "kaiser", 1));
	}
	
}