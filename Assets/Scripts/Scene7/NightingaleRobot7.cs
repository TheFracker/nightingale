using UnityEngine;
using System.Collections;

public class NightingaleRobot7 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "nightingale robot", 1));
	}
	
}