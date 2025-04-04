using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour {

	public TextMeshPro gemCounter;
	GameObject [] totalGems;
	public TextMeshPro livesCounter;
	int lives;
	public TextMeshPro gameTimer;
	string Timer;
	GameObject Hero;

	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		totalGems = GameObject.FindGameObjectsWithTag ("redGem");
		gemCounter.text = "Gems: " + totalGems.Length.ToString ();
		lives = Hero.GetComponent<HeroMovement> ().lives;
		livesCounter.text = "Lives:" + lives;
		gameTimer.text = "Time: " + Time.timeSinceLevelLoad.ToString("0.00");

	}
}
