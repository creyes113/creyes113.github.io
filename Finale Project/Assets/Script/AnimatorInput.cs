using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInput : MonoBehaviour {

	Animator myAnim;
	int current;
	int current2;



	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();
		current = 0;
		current2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) ) {

			current = 1;
		} else{
			current = 0;
		}
		if (Input.GetKey (KeyCode.A) ) {

			current2 = 1;
		} else{
			current2 = 0;
		}
		myAnim.SetInteger ("whichstate", current);
		myAnim.SetInteger ("secondstate", current2);
	}
}
