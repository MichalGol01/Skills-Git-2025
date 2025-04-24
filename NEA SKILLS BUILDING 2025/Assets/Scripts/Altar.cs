﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Altar : MonoBehaviour {

	private void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Player") {
			if (SceneManager.GetActiveScene ().name == "Level 2") {
				SceneManager.LoadScene ("Won");
			} 
			else {
				SceneManager.LoadScene ("Level 2");
			}
				
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
