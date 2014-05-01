using UnityEngine;
using System.Collections;

public class ServantSounds2 : MonoBehaviour {

	AudioSource servant1;
	AudioSource servant2;
	AudioSource[] servantSounds = new AudioSource[2];
	int lastServantSound = 0;
	
	void Start () {
		servant1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		servant2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene2/servants-01") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene2/servants-02") as AudioClip;
		
		servant1.clip = ac1;
		servant2.clip = ac2;
		
		servantSounds [0] = servant1;
		servantSounds [1] = servant2;
	}
	
	void OnMouseUpAsButton()
	{
		servantSounds [lastServantSound].Stop ();
		int servant = Random.Range (0, 2);
		servantSounds [servant].Play ();
		lastServantSound = servant;
	}
}
