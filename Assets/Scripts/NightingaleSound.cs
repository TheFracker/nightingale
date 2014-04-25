using UnityEngine;
using System.Collections;

public class NightingaleSound : MonoBehaviour {

	AudioSource tweet1;
	AudioSource tweet2;
	AudioSource tweet3;
	AudioSource[] tweets = new AudioSource[3];
	int lastTweet = 0;

	void Start () 
	{
		tweet1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		tweet2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		tweet3 = gameObject.AddComponent ("AudioSource") as AudioSource;

		AudioClip ac1 = Resources.Load("Nightingale1") as AudioClip;
		AudioClip ac2 = Resources.Load("Nightingale2") as AudioClip;
		AudioClip ac3 = Resources.Load("Nightingale3") as AudioClip;

		tweet1.clip = ac1;
		tweet2.clip = ac2;
		tweet3.clip = ac3;

		tweets [0] = tweet1;
		tweets [1] = tweet2;
		tweets [2] = tweet3;
	}

	void OnMouseUpAsButton()
	{
		tweets [lastTweet].Stop ();
		int tweet = Random.Range (0, 3);
		tweets [tweet].Play ();
		lastTweet = tweet;
	}
}
