using UnityEngine;
using System.Collections;

public class WaiterSounds7 : MonoBehaviour {

	AudioSource waiter1;
	AudioSource waiter2;
	AudioSource waiter3;
	AudioSource[] waiterSounds = new AudioSource[3];
	int lastWaiterSound = 0;
	
	void Start () {
		waiter1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		waiter2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		waiter3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene7/LongServantSigh1") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene7/LongServantSigh2") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/Scene7/LongServantSigh3") as AudioClip;

		waiter1.clip = ac1;
		waiter2.clip = ac2;
		waiter3.clip = ac3;

		waiterSounds [0] = waiter1;
		waiterSounds [1] = waiter2;
		waiterSounds [2] = waiter3;
	}
	
	void OnMouseUpAsButton()
	{
		waiterSounds [lastWaiterSound].Stop ();
		int waiter = Random.Range (0, 3);
		waiterSounds [waiter].Play ();
		lastWaiterSound = waiter;
	}
}
