using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private void OnCollisonEnter (Collider other) {

		if (other.gameObject.tag == "boundary") {
			Debug.Log("Camera has hit wall!!!!!!!!!!!");
		}
		Debug.Log("Camera has hit wall!");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
