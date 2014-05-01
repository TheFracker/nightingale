using UnityEngine;
using System.Collections;

public class NightingaleSound : MonoBehaviour {

	AudioSource tweet1;
	AudioSource tweet2;
	AudioSource tweet3;
	AudioSource tweet4;
	AudioSource[] tweets = new AudioSource[4];
	int lastTweet = 0;

	void Start () 
	{
		tweet1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		tweet2 = gameObject.AddComponent ("AudioSource") as AudioSource;
		tweet3 = gameObject.AddComponent ("AudioSource") as AudioSource;
		tweet4 = gameObject.AddComponent ("AudioSource") as AudioSource;

		AudioClip ac1 = Resources.Load("Non-Iconic/Nightingale1") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Nightingale2") as AudioClip;
		AudioClip ac3 = Resources.Load("Non-Iconic/Nightingale3") as AudioClip;
		AudioClip ac4 = Resources.Load("Non-Iconic/Nightingale4") as AudioClip;

		tweet1.clip = ac1;
		tweet2.clip = ac2;
		tweet3.clip = ac3;
		tweet4.clip = ac4;

		tweets [0] = tweet1;
		tweets [1] = tweet2;
		tweets [2] = tweet3;
		tweets [3] = tweet4;
	}

	void OnMouseUpAsButton()
	{
		tweets [lastTweet].Stop ();
		int tweet = Random.Range (0, 4);
		tweets [tweet].Play ();
		lastTweet = tweet;
	}
}
