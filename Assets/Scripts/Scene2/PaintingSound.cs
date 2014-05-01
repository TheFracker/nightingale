using UnityEngine;
using System.Collections;

public class PaintingSound : MonoBehaviour {

	AudioSource frame1;
	AudioSource frame2;
	AudioSource[] frames = new AudioSource[2];
	int lastFrame = 0;
	
	void Start () {
		frame1 = gameObject.AddComponent ("AudioSource") as AudioSource;
		frame2 = gameObject.AddComponent ("AudioSource") as AudioSource;

		AudioClip ac1 = Resources.Load("Non-Iconic/Scene2/ramme") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/Scene2/ramme2") as AudioClip;

		frame1.clip = ac1;
		frame2.clip = ac2;

		frames [0] = frame1;
		frames [1] = frame2;
	}

	void OnMouseUpAsButton()
	{
		frames [lastFrame].Stop ();
		int frame = Random.Range (0, 2);
		frames [frame].Play ();
		lastFrame = frame;
	}
}
