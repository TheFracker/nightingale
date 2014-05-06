using UnityEngine;
using System.Collections;

public class VaseSounds : MonoBehaviour {

	AudioSource vase1;
	AudioSource vase2;
	AudioSource vase3;
	AudioSource[] vases = new AudioSource[3];
	int lastVase = 0;
	
	void Start () 
	{
		vase1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		vase2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		vase3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/vase") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/vase2") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/vase3") as AudioClip;
		
		vase1.clip = ac1;
		vase2.clip = ac2;
		vase3.clip = ac3;

		vase1.rolloffMode = AudioRolloffMode.Linear;
		vase2.rolloffMode = AudioRolloffMode.Linear;
		vase3.rolloffMode = AudioRolloffMode.Linear;

		vase1.volume = 0.7f;
		vase2.volume = 0.7f;
		vase3.volume = 0.7f;

		vases [0] = vase1;
		vases [1] = vase2;
		vases [2] = vase3;
	}
	
	void OnMouseUpAsButton()
	{
		vases [lastVase].Stop ();
		int vase = Random.Range (0, 3);
		vases [vase].Play ();
		lastVase = vase;
	}
}
