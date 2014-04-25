using UnityEngine;
using System.Collections;

public class NightingaleRobot7 : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene7ClickMessage", "nightingale robot", ++click));
	}
	
}