using UnityEngine;
using System.Collections;

public class MessageListener : MessageBehaviour {

	int butterflyClicks;

	protected override void OnStart () {
		butterflyClicks = 0;
		// register a listener for one of our methods
		Messenger.RegisterListener(new Listener("ClickMessage", gameObject, "HandleClickMessage"));
		
	}
	
	// handler for NewPlayer messages
	public void HandleClickMessage(ClickMessage m)
	{
		if(m.MessageValue == "butterfly")
			butterflyClicks = m.value;
	}

	void OnApplicationQuit()
	{
		string filePath = Application.persistentDataPath + "/results.txt";
		string toPrint = "Butterfly Clicks: " + butterflyClicks + " Some \n";
		System.IO.File.AppendAllText (filePath, toPrint);
	}

}
