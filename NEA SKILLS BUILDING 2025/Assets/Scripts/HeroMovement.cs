using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovement : MonoBehaviour {

	Rigidbody2D rb;
	float speed;
	public int lives;

	private void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "extraLife") {
			lives += 1;
			Destroy (other.gameObject);
		}
	}

	void setLives(){

		lives -= 1;

			if ( lives <= 0)
			{
				Debug.Log("End  of Game");
				SceneManager.LoadScene ("Lost");
			}
	}

	void resetPosition() {
		Debug.Log ("Spiked Recived!");
		transform.SetPositionAndRotation (new Vector3 (-5.49f, 0.8f, 0), Quaternion.identity);
		setLives ();
	}

	void Start () {
		speed = 5.1f;
		rb = GetComponent<Rigidbody2D> ();
		lives = 3;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.AddForce (Vector2.up * 300);
		}
	}
}
