﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {


	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnZ = 5.0f;
	private float tileLength = 10.0f;
	private int amnTilesOnScreen = 1;
	// Use this for initialization
	private void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		for (int i = 0; i < amnTilesOnScreen; i++) {

			SpawnTile ();
		}
	}

	// Update is called once per frame
	private void Update () {
		if(playerTransform.position.z > (spawnZ - amnTilesOnScreen * tileLength))
		{

			SpawnTile ();

		}

	} 

	private void SpawnTile(int prefabindex = -1) {

		GameObject go;
		go = Instantiate (tilePrefabs [0]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLength;
	}
}
