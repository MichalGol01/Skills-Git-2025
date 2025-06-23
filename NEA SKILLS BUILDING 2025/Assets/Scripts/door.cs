using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

	public Sprite Door;
	SpriteRenderer enemyDoor;
	public Sprite redDoor;
	public Sprite greenDoor;
	public Sprite orangeDoor;
	public Sprite Doorext;

	// Use this for initialization
	void Start () {
		enemyDoor = GetComponent<SpriteRenderer>();
		Doorext = Resources.Load<Sprite> ("X:/GitHub/Skills-Git-2025/NEA SKILLS BUILDING 2025/Assets/Sprites/Tiles/doorRedStroked.png");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			enemyDoor.sprite = redDoor;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha1)) {
			enemyDoor.sprite = Doorext;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			enemyDoor.sprite = greenDoor;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			enemyDoor.sprite = orangeDoor;
		}
	}
}
