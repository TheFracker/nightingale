using UnityEngine;
using System.Collections;

public class FrogSounds : MonoBehaviour {

	AudioSource ribbit1;
	AudioSource ribbit2;
	AudioSource ribbit3;
	AudioSource[] ribbits = new AudioSource[3];
	int lastRibbit = 0;
	
	void Start () 
	{
		ribbit1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		ribbit2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		ribbit3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		
		AudioClip ac1 = Resources.Load("Non-Iconic/Scene1/Frog_1") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene1/Frog_2") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/Scene1/Frog_3") as AudioClip;
		
		ribbit1.clip = ac1;
		ribbit2.clip = ac2;
		ribbit3.clip = ac3;
		
		ribbits [0] = ribbit1;
		ribbits [1] = ribbit2;
		ribbits [2] = ribbit3;
	}
	
	void OnMouseUpAsButton()
	{
		ribbits [lastRibbit].Stop ();
		int ribbit = Random.Range (0, 3);
		ribbits [ribbit].Play ();
		lastRibbit = ribbit;
	}
}
