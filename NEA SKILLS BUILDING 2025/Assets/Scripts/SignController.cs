using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignController : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other) {

		Debug.Log ("The sign has felt your presence!");
	}

	private void OnTriggerExit2D(Collider2D other) {

		Debug.Log ("The sign can no longer feel your presence! Come Back!");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
