﻿using UnityEngine;
using System.Collections;

public class Anim : MonoBehaviour {

	Animator anim;
	float animTime;
	float minTime;
	float maxTime;
	
	void Start () {
		// Acces to the animator
		anim = this.gameObject.GetComponent<Animator> ();

		// Time until an animation is played, showing the user what objects can be pressed
		minTime = 10;
		maxTime = 20;
		animTime = Time.time + Random.Range (minTime, maxTime);
	}

	void Update () {
		if(animTime < Time.time)
		{
			anim.SetBool ("playAnim", true);
			animTime = Time.time + Random.Range (minTime, maxTime);
			StartCoroutine("turnOffAnim");
		}
	}

	void OnMouseDown()
	{
		anim.SetBool ("wasPushed", true);
	}

	void OnMouseUp()
	{
		anim.SetBool ("wasPushed", false);
	}

	IEnumerator turnOffAnim()
	{
		yield return new WaitForSeconds(0.5f);
		anim.SetBool ("playAnim", false);
	}
}
