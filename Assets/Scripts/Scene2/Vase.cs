﻿using UnityEngine;
using System.Collections;

public class Vase : MessageBehaviour {
	
	int click = 0;
	
	void OnMouseUpAsButton()
	{
		Messenger.SendToListeners(new ClickMessage(gameObject, "Scene2ClickMessage", "vases", ++click));
	}
	
}