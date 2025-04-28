using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SignController : MonoBehaviour {

	public TextMeshPro signText;

	private void OnTriggerEnter2D(Collider2D other) {

		// will run once when you enter the trigger
		Debug.Log ("The sign has felt your presence!");
		signText.text = "The sign has felt your presence";
	}

	private void OnTriggerExit2D(Collider2D other) {

		//run once you left the trigger
		Debug.Log ("The sign can no longer feel your presence! Come Back!");
	}
	private void OnTriggerStay2D(Collider2D other) {

		//runs each time you move inside the trigger
		Debug.Log("Why are you still here? Go away!");
		signText.text = "The sign can no longer feel your presence Come back!";
	}
	// Use this for initialization
	void Start () {
		signText = GetComponentInChildren<TextMeshPro> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
