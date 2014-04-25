using UnityEngine;
using System.Collections;

public class NightingaleRobot5 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene5ClickMessage", "nightingale robot", 1k));
	}
	
}