using UnityEngine;
using System.Collections;

public class LampSound : MonoBehaviour {

	AudioSource turnOn;
	AudioSource turnOff;
	bool isOn;
	Animator anim;
	
	void Start () {
		anim = gameObject.GetComponent<Animator> ();

		isOn = true;

		turnOn = gameObject.AddComponent ("AudioSource") as AudioSource;
		turnOff = gameObject.AddComponent ("AudioSource") as AudioSource;

		AudioClip ac1 = Resources.Load("Non-Iconic/match") as AudioClip;
		AudioClip ac2 = Resources.Load("Non-Iconic/puffblow") as AudioClip;

		turnOn.clip = ac1;
		turnOff.clip = ac2;
	}

	void OnMouseUpAsButton()
	{
		if(isOn)
		{
			turnOn.Stop();
			turnOff.Play();
			isOn = false;
			anim.SetBool("isOn", false);
		}
		else
		{
			turnOff.Stop();
			turnOn.Play ();
			isOn = true;
			anim.SetBool("isOn", true);
		}
	}
}
