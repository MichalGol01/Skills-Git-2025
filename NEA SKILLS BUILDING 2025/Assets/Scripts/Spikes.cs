﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	GameObject Hero;

	private void OnCollisionEnter2D(Collision2D other) {
		Debug.Log ("SPIKED!");
		Hero.SendMessage ("resetPosition");
	}


	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
