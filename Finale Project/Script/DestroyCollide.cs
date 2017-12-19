using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionEnter (Collision collisionReport){
		Destroy(collisionReport.gameObject); 
	}
}

