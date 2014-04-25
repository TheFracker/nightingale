using UnityEngine;
using System.Collections;

public class Nightingale9 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene9ClickMessage", "nightingale", 1));
	}
	
}