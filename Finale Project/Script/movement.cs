using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour {

	public GameObject mover;
	Vector3 moverOrigin;
	public Vector3 startingposition;
	public GameObject winSpot;
	public int movementAmt = 1;
	public Text countText;
	private int count;
	public AudioSource moverAudSrc;
	public AudioClip winsound;
	// Use this for initialization
	void Start () {

		startingposition = mover.transform.position;
		count = 0;
		//SetCountText ();
	}

	// Update is called once per frame
	  void Update () {

		//check if mover's transform.position.* is beyond each threshold
		if (mover.transform.position.y < 9 || //is it behind the grid?
			mover.transform.position.y > -9 || //is it too far off the grid?
			mover.transform.position.x< 6|| //is it too far left of the grid?
			mover.transform.position.x > -9 ) { //is it too far right of the grid?
			mover.transform.position = startingposition; //if any of those are true... reset it's position to the starting position
		}

		//check if mover's transform.position has the same...
		if (mover.transform.position ==
			new Vector3 (mover.transform.position.x, //...x as winSpot
				winSpot.transform.position.y, //...y as itself, because the winSpot is below it and we don't care about the y
				winSpot.transform.position.z)) { //z as winSpot
			//if so...
			Debug.Log ("win?"); //give us a console message

			mover.GetComponent<MeshRenderer> ().material.color = Color.red; //access the color through 

			moverAudSrc.PlayOneShot (winsound, 1.0f); // when the player is over the winspot this clip will play once. 
		}


		if (Input.GetKeyDown (KeyCode.A)) {
			mover.transform.position += new Vector3 (0, 0, -movementAmt);
		}
		if (Input.GetKeyDown (KeyCode.D)) {            
			mover.transform.position += new Vector3 (0, 0, movementAmt);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			mover.transform.position += new Vector3 (0, movementAmt, 0);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			mover.transform.position += new Vector3 (0, -movementAmt, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			mover.transform.position += new Vector3 (0, 2, 0);
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("points"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			//setCountText ();
		}
	
}


}


	


