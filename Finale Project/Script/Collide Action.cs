﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAction : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision collisionReport){
		Debug.Log ("ya done collid'd");
	}
}
