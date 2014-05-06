using UnityEngine;
using System.Collections;

public class BtnAnim : MonoBehaviour {

	Animator anim;
	
	void Awake () {
		anim = this.gameObject.GetComponent<Animator> ();
	}

	void OnMouseDown()
	{
		anim.SetBool ("btnDown", true);
		anim.SetBool ("btnUp", false);
	}

	void OnMouseUp()
	{
		anim.SetBool ("btnDown", false);
		anim.SetBool ("btnUp", true);
	}
}
