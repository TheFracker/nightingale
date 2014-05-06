using UnityEngine;
using System.Collections;

public class EnterName : MessageBehaviour {

	string nameOfChild = "Navn på barnet";
	int x;
	int y;
	int width;
	int height;
	bool pressedOK;

	void Awake()
	{
		pressedOK = false;
		width = 200;
		height = 30;
		x = (Screen.width/2) - (width/2);
		y = (Screen.height/2) - (height/2);
	}

	void OnGUI()
	{
		if(!pressedOK)
		{
			nameOfChild = GUI.TextField (new Rect (x, y, width, height), nameOfChild);
			if(GUI.Button(new Rect(x, y+height, width, height), "OK"))
			{
				Messenger.SendToListeners(new Message(gameObject, "GetName", nameOfChild));
				pressedOK = true;
			}
		}
	}
}
