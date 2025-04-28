using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	private void OnDestroy() {

		Debug.Log ("A bomb was destroyed");

	}

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10);
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (Random.Range(-5.0f,5.0f), Random.Range(-8.0f,8.0f)), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
