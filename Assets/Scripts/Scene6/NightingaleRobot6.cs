using UnityEngine;
using System.Collections;

public class NightingaleRobot6 : MessageBehaviour {

	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene6ClickMessage", "nightingale robot", 1));
	}
	
}