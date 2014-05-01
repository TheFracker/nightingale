using UnityEngine;
using System.Collections;

public class KaiserSounds2 : MonoBehaviour {

	AudioSource kaiser1;
	AudioSource kaiser2;
	AudioSource[] kaiserSounds = new AudioSource[2];
	int lastKaiserSound = 0;
	
	void Start () {
		kaiser1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		kaiser2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene2/empror-01") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene2/empror-02") as AudioClip;
		
		kaiser1.clip = ac1;
		kaiser2.clip = ac2;
		
		kaiserSounds [0] = kaiser1;
		kaiserSounds [1] = kaiser2;
	}
	
	void OnMouseUpAsButton()
	{
		kaiserSounds [lastKaiserSound].Stop ();
		int kaiser = Random.Range (0, 2);
		kaiserSounds [kaiser].Play ();
		lastKaiserSound = kaiser;
	}
}
