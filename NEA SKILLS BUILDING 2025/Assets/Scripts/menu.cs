using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour {

	private Canvas mainCanvas;

	public void ClickedButtonMenu(){

		Debug.Log("Button menu Clicked!");
		SceneManager.LoadScene("menu");
	}
	public void ClickedButtonDino(){

		Debug.Log("Button Dino Clicked!");
		SceneManager.LoadScene("Animations");
	}
	public void ClickedButtonlt(){

		Debug.Log("Button levels tutorial Clicked!");
		SceneManager.LoadScene("Levels Tutorial");
	}
	public void ClickedButtonEnemy(){

		Debug.Log("Button Enemy Scence Clicked!");
		SceneManager.LoadScene("enemy");
	}
	public void ClickedButtonnavigation(){

		Debug.Log("Button navigation Clicked!");
		SceneManager.LoadScene("Navigation");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
