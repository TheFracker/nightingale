using UnityEngine;
using System.Collections;

public class KaiserSounds3 : MonoBehaviour {

	AudioSource kaiser1;
	AudioSource kaiser2;
	AudioSource kaiser3;
	AudioSource[] kaiserSounds = new AudioSource[3];
	int lastKaiserSound = 0;
	
	void Start () 
	{
		kaiser1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		kaiser2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		kaiser3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene3/emperor-01") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene3/emperor-02") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/Scene3/emperor-03") as AudioClip;
		
		kaiser1.clip = ac1;
		kaiser2.clip = ac2;
		kaiser3.clip = ac3;
		
		kaiserSounds [0] = kaiser1;
		kaiserSounds [1] = kaiser2;
		kaiserSounds [2] = kaiser3;
	}
	
	void OnMouseUpAsButton()
	{
		kaiserSounds [lastKaiserSound].Stop ();
		int kaiser = Random.Range (0, 3);
		kaiserSounds [kaiser].Play ();
		lastKaiserSound = kaiser;
	}
}
