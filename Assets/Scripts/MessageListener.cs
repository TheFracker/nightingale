using UnityEngine;
using System.Collections;

public class MessageListener : MessageBehaviour {

	// Scene1
	int butterflyClicks;
	int frogClicks;
	int kaiser1Clicks;
	int waiter1Clicks;
	int nightingale1Clicks;
	int cowClicks;
	int servants1Clicks;
	int flowersClicks;
	int bellClicks;

	// Scene2
	int kaiser2Clicks;
	int waiter2Clicks;
	int servants2Clicks;
	int nightingale2Clicks;
	int vase2Clicks;
	int paintingClicks;
	int lamps2Clicks;

	// Scene3
	int kaiser3Clicks;
	int waiter3Clicks;
	int nightingale3Clicks;
	int vase3Clicks;
	int crowd3Clicks;
	int lamps3Clicks;

	// Scene4
	int nightingale4Clicks;
	int servants4Clicks;
	int ribbonClicks;
	int lamps4Clicks;

	// Scene5
	int nightingale5Clicks;
	int nightingaleRobot5Clicks;
	int waiter5Clicks;
	int kaiser5Clicks;
	int mechanicClicks;
	int vase5Clicks;
	int crowd5Clicks;
	int lamps5Clicks;

	// Scene6
	int nightingale6Clicks;
	int nightingaleRobot6Clicks;
	int servants6Clicks;
	int kaiser6Clicks;
	int waiter6Clicks;
	int lamps6Clicks;

	// Scene7
	int kaiser7Clicks;
	int waiter7Clicks;
	int nightingale7Clicks;
	int nightingaleRobot7Clicks;
	int crowd7Clicks;
	int curtainsClicks;
	int vase7Clicks;
	int lamps7Clicks;

	// Scene8
	int nightingale8Clicks;
	int kaiser8Clicks;
	int waiter8Clicks;
	int crowd8Clicks;
	int vase8Clicks;
	int lamps8Clicks;

	// Scene9
	int nightingale9Clicks;
	int waiter9Clicks;
	int kaiser9Clicks;
	int servants9Clicks;
	int lamps9Clicks;


	protected override void OnStart () {
		// Scene1
		butterflyClicks = 0;
		frogClicks = 0;
		kaiser1Clicks = 0;
		waiter1Clicks = 0;
		cowClicks = 0;
		bellClicks = 0;
		servants1Clicks = 0;
		flowersClicks = 0;
		nightingale1Clicks = 0;

		// Scene2
		kaiser2Clicks = 0;
		waiter2Clicks = 0;
		servants2Clicks = 0;
		nightingale2Clicks = 0;
		vase2Clicks = 0;
		paintingClicks = 0;
		lamps2Clicks = 0;

		// Scene3
		kaiser3Clicks = 0;
		waiter3Clicks = 0;
		nightingale3Clicks = 0;
		vase3Clicks = 0;
		crowd3Clicks = 0;
		lamps3Clicks = 0;

		// Scene4
		nightingale4Clicks = 0;
		servants4Clicks = 0;
		ribbonClicks = 0;
		lamps4Clicks = 0;

		// Scene5
		nightingale5Clicks = 0;
		nightingaleRobot5Clicks = 0;
		waiter5Clicks = 0;
		kaiser5Clicks = 0;
		mechanicClicks = 0;
		vase5Clicks = 0;
		crowd5Clicks = 0;
		lamps5Clicks = 0;

		// Scene6
		nightingale6Clicks = 0;
		nightingaleRobot6Clicks = 0;
		servants6Clicks = 0;
		kaiser6Clicks = 0;
		waiter6Clicks = 0;
		lamps6Clicks = 0;

		// Scene7
		kaiser7Clicks = 0;
		waiter7Clicks = 0;
		nightingale7Clicks = 0;
		nightingaleRobot7Clicks = 0;
		crowd7Clicks = 0;
		curtainsClicks = 0;
		vase7Clicks = 0;
		lamps7Clicks = 0;

		// Scene8
		nightingale8Clicks = 0;
		kaiser8Clicks = 0;
		waiter8Clicks = 0;
		crowd8Clicks = 0;
		vase8Clicks = 0;
		lamps8Clicks = 0;

		// Scene9
		nightingale9Clicks = 0;
		waiter9Clicks = 0;
		servants9Clicks = 0;
		lamps9Clicks = 0;

		// register a listener for one of our methods
		Messenger.RegisterListener(new Listener("Scene1ClickMessage", gameObject, "HandleClickScene1Message"));
		Messenger.RegisterListener(new Listener("Scene2ClickMessage", gameObject, "HandleClickScene2Message"));
		Messenger.RegisterListener(new Listener("Scene3ClickMessage", gameObject, "HandleClickScene3Message"));
		Messenger.RegisterListener(new Listener("Scene4ClickMessage", gameObject, "HandleClickScene4Message"));
		Messenger.RegisterListener(new Listener("Scene5ClickMessage", gameObject, "HandleClickScene5Message"));
		Messenger.RegisterListener(new Listener("Scene6ClickMessage", gameObject, "HandleClickScene6Message"));
		Messenger.RegisterListener(new Listener("Scene7ClickMessage", gameObject, "HandleClickScene7Message"));
		Messenger.RegisterListener(new Listener("Scene8ClickMessage", gameObject, "HandleClickScene8Message"));
		Messenger.RegisterListener(new Listener("Scene9ClickMessage", gameObject, "HandleClickScene9Message"));

		
	}
	
	// handler for NewPlayer messages
	public void HandleClickScene1Message(ClickMessage m)
	{
		if(m.MessageValue == "butterfly")
			butterflyClicks += m.value;
		else if (m.MessageValue == "nightingale")
			nightingale1Clicks += m.value;
		else if (m.MessageValue == "frog")
			frogClicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser1Clicks += m.value;
		else if (m.MessageValue == "cow")
			cowClicks += m.value;
		else if (m.MessageValue == "bells")
			bellClicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter1Clicks += m.value;
		else if (m.MessageValue == "servants")
			servants1Clicks += m.value;
		else if (m.MessageValue == "flowers")
			flowersClicks += m.value;
	}

	public void HandleClickScene2Message(ClickMessage m)
	{
		if(m.MessageValue == "kaiser")
			kaiser2Clicks += m.value;
		else if (m.MessageValue == "nightingale")
			nightingale2Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter2Clicks += m.value;
		else if (m.MessageValue == "servants")
			servants2Clicks += m.value;
		else if (m.MessageValue == "vases")
			vase2Clicks += m.value;
		else if (m.MessageValue == "paintings")
			paintingClicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps2Clicks += m.value;
	}

	public void HandleClickScene3Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale3Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser3Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter3Clicks += m.value;
		else if (m.MessageValue == "vases")
			vase3Clicks += m.value;
		else if (m.MessageValue == "crowd")
			crowd3Clicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps3Clicks += m.value;
	}

	public void HandleClickScene4Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale4Clicks += m.value;
		else if (m.MessageValue == "servant")
			servants4Clicks += m.value;
		else if (m.MessageValue == "ribbons")
			ribbonClicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps4Clicks += m.value;
	}

	public void HandleClickScene5Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale5Clicks += m.value;
		else if (m.MessageValue == "nightingale robot")
			nightingaleRobot5Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser5Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter5Clicks += m.value;
		else if (m.MessageValue == "mechanic")
			mechanicClicks += m.value;
		else if (m.MessageValue == "vases")
			vase5Clicks += m.value;
		else if (m.MessageValue == "crowd")
			crowd5Clicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps5Clicks += m.value;
	}

	public void HandleClickScene6Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale6Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser6Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter6Clicks += m.value;
		else if (m.MessageValue == "nightingale robot")
			nightingaleRobot6Clicks += m.value;
		else if (m.MessageValue == "servants")
			servants6Clicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps6Clicks += m.value;
	}

	public void HandleClickScene7Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale7Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser7Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter7Clicks += m.value;
		else if (m.MessageValue == "nightingale robot")
			nightingaleRobot7Clicks += m.value;
		else if (m.MessageValue == "crowd")
			crowd7Clicks += m.value;
		else if (m.MessageValue == "vases")
			vase7Clicks += m.value;
		else if (m.MessageValue == "curtains")
			curtainsClicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps7Clicks += m.value;
	}

	public void HandleClickScene8Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale8Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser8Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter8Clicks += m.value;
		else if (m.MessageValue == "crowd")
			crowd8Clicks += m.value;
		else if (m.MessageValue == "vases")
			vase8Clicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps8Clicks += m.value;
	}

	public void HandleClickScene9Message(ClickMessage m)
	{
		if (m.MessageValue == "nightingale")
			nightingale9Clicks += m.value;
		else if (m.MessageValue == "kaiser")
			kaiser9Clicks += m.value;
		else if (m.MessageValue == "waiter")
			waiter9Clicks += m.value;
		else if (m.MessageValue == "servants")
			servants9Clicks += m.value;
		else if (m.MessageValue == "lamps")
			lamps9Clicks += m.value;
	}

	void OnApplicationPause() // Should be changed to OnApplicationPause() for tablet
	{
		string filePath = Application.persistentDataPath + "/results.txt";
		string toPrint = createStringToPrint();
		System.IO.File.AppendAllText (filePath, toPrint);
	}

	string createStringToPrint()
	{
		string start = "\n\n------------------ START ------------------\n\n";
		string end = "\n\n------------------- END -------------------\n\n";
		char nl = '\n';
		string total = start + "\n\n----------------- SCENE 1 -----------------\n\n" +
			"Kaiser: " + kaiser1Clicks + nl +
			"Waiter: " + waiter1Clicks + nl +
			"Nightingale: " + nightingale1Clicks + nl +
			"Servants: " + servants1Clicks + nl +
			"Frog: " + frogClicks + nl +
			"Butterfly: " + butterflyClicks + nl +
			"Cow: " + cowClicks + nl +
			"Bells: " + bellClicks + nl +
			"Flowers: " + flowersClicks +
			"\n\n----------------- SCENE 2 -----------------\n\n" +
			"Kaiser: " + kaiser2Clicks + nl +
			"Waiter: " + waiter2Clicks + nl +
			"Nightingale: " + nightingale2Clicks + nl +
			"Servants: " + servants2Clicks + nl +
			"Vases: " + vase2Clicks + nl +
			"Paintings: " + paintingClicks + nl +
			"Lamps: " + lamps2Clicks +
			"\n\n----------------- SCENE 3 -----------------\n\n" +
			"Kaiser: " + kaiser3Clicks + nl +
			"Waiter: " + waiter3Clicks + nl +
			"Nightingale: " + nightingale3Clicks + nl +
			"Vases: " + vase3Clicks + nl +
			"Crowd: " + crowd3Clicks + nl + 
			"Lamps: " + lamps3Clicks + nl +
			"\n\n----------------- SCENE 4 -----------------\n\n" +
			"Nightingale: " + nightingale4Clicks + nl +
			"Servants: " + servants4Clicks + nl +
			"Ribbons: " + ribbonClicks + nl +
			"Lamps: " + lamps4Clicks + nl +
			"\n\n----------------- SCENE 5 -----------------\n\n" +
			"Kaiser: " + kaiser5Clicks + nl +
			"Waiter: " + waiter5Clicks + nl +
			"Nightingale: " + nightingale5Clicks + nl +
			"Nightingale Robot: " + nightingaleRobot5Clicks + nl +
			"Mechanic: " + mechanicClicks + nl +
			"Vase: " + vase5Clicks + nl + 
			"Crowd: " + crowd5Clicks + nl +
			"Lamps: " + lamps5Clicks + nl +
			"\n\n----------------- SCENE 6 -----------------\n\n" +
			"Kaiser: " + kaiser6Clicks + nl +
			"Waiter: " + waiter6Clicks + nl + 
			"Nightingale: " + nightingale6Clicks + nl +
			"Nightingale Robot: " + nightingaleRobot6Clicks + nl +
			"Servants: " + servants6Clicks + nl +
			"Lamps: " + lamps6Clicks + nl +
			"\n\n----------------- SCENE 7 -----------------\n\n" +
			"Kaiser: " + kaiser7Clicks + nl +
			"Waiter: " + waiter7Clicks + nl +
			"Nightingale: " + nightingale7Clicks + nl +
			"Nightingale Robot: " + nightingaleRobot7Clicks + nl +
			"Crowd: " + crowd7Clicks + nl +
			"Curtains: " + curtainsClicks + nl +
			"Vases: " + vase7Clicks + nl +
			"Lamps: " + lamps7Clicks + nl +
			"\n\n----------------- SCENE 8 -----------------\n\n" +
			"Kaiser: " + kaiser8Clicks + nl +
			"Waiter: " + waiter8Clicks + nl +
			"Nightingale: " + nightingale8Clicks + nl +
			"Crowd: " + crowd8Clicks + nl +
			"Vases: " + vase8Clicks + nl +
			"Lamps: " + lamps8Clicks + nl +
			"\n\n----------------- SCENE 9 -----------------\n\n" +
			"Kaiser: " + kaiser9Clicks + nl +
			"Waiter: " + waiter9Clicks + nl +
			"Nightingale: " + nightingale9Clicks + nl +
			"Servants: " + servants9Clicks + nl +
			"Lamps: " + lamps9Clicks + end;
		return total;
	}

}
