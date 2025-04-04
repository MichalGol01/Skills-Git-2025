using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject Alter;
	bool  Spawned;
	Vector3 SpawnedPosition;


	public void SpawnAlter () {
		if (Spawned == false) {
			Instantiate (Alter, SpawnedPosition, Quaternion.identity);
			Spawned = true;	
			Debug.Log ("Alter Spawned");
		}

	}

	// Use this for initialization
	void Start () {
		Spawned = false;
		SpawnedPosition = new Vector3 (-5.49f, -2.24f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
