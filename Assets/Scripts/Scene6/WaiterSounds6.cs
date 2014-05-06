using UnityEngine;
using System.Collections;

public class WaiterSounds6 : MonoBehaviour {

	AudioSource waiter1;
	AudioSource waiter2;
	AudioSource[] waiterSounds = new AudioSource[2];
	int lastWaiterSound = 0;
	
	void Start () {
		waiter1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		waiter2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene6/Long servant-01") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene6/Long servant-02") as AudioClip;
		
		waiter1.clip = ac1;
		waiter2.clip = ac2;

		waiter1.rolloffMode = AudioRolloffMode.Linear;
		waiter2.rolloffMode = AudioRolloffMode.Linear;

		waiter1.volume = 0.35f;
		waiter2.volume = 0.35f;
		
		waiterSounds [0] = waiter1;
		waiterSounds [1] = waiter2;
	}
	
	void OnMouseUpAsButton()
	{
		waiterSounds [lastWaiterSound].Stop ();
		int waiter = Random.Range (0, 2);
		waiterSounds [waiter].Play ();
		lastWaiterSound = waiter;
	}
}
