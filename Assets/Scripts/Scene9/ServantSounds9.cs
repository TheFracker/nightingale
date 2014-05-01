using UnityEngine;
using System.Collections;

public class ServantSounds9 : MonoBehaviour {

	AudioSource servant1;
	AudioSource servant2;
	AudioSource servant3;
	AudioSource servant4;
	AudioSource[] servantSounds = new AudioSource[4];
	int lastServantSound = 0;
	
	void Start () 
	{
		servant1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		servant2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		servant3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		servant4 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Nightingale1") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Nightingale2") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/Nightingale3") as AudioClip;
		AudioClip ac4 = Resources.Load("Non-Iconic/Nightingale4") as AudioClip;
		
		servant1.clip = ac1;
		servant2.clip = ac2;
		servant3.clip = ac3;
		servant3.clip = ac4;
		
		servantSounds [0] = servant1;
		servantSounds [1] = servant2;
		servantSounds [2] = servant3;
		servantSounds [3] = servant4;
	}
	
	void OnMouseUpAsButton()
	{
		servantSounds [lastServantSound].Stop ();
		int servant = Random.Range (0, 4);
		servantSounds [servant].Play ();
		lastServantSound = servant;
	}
}
