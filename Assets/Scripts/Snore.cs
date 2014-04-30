using UnityEngine;
using System.Collections;

public class Snore : MonoBehaviour {

	Animator anim;
	float animTime;
	float minTime;
	float maxTime;
	bool setActive;

	// Use this for initialization
	void Start () {
		this.gameObject.collider2D.enabled = false;
		setActive = false;

		// Acces to the animator
		anim = this.gameObject.GetComponent<Animator> ();
		
		// Time until an animation is played, showing the user what objects can be pressed
		minTime = 10;
		maxTime = 20;
	}
	
	// Update is called once per frame
	void Update () {
		if(Right.pushedToSide && Left.pushedToSide && !setActive)
		{
			this.gameObject.collider2D.enabled = true;
			setActive = true;
			animTime = Time.time + Random.Range (5, 10);
		}

		if(animTime < Time.time && setActive)
		{
			anim.SetBool ("playAnim", true);
			animTime = Time.time + Random.Range (minTime, maxTime);
			StartCoroutine("turnOffAnim");
		}

	}
	
	void OnMouseDown()
	{
		if(Right.pushedToSide && Left.pushedToSide)
			anim.SetBool ("wasPushed", true);
	}
	
	void OnMouseUp()
	{
		if(Right.pushedToSide && Left.pushedToSide)
			anim.SetBool ("wasPushed", false);
	}
	
	IEnumerator turnOffAnim()
	{
		yield return new WaitForSeconds(0.5f);
		anim.SetBool ("playAnim", false);
	}
}
