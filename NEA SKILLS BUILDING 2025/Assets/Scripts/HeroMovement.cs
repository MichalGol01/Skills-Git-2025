using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovement : MonoBehaviour {

	public GameObject MainCamera;
	Rigidbody2D rb;
	float speed;
	public int lives;
	bool vulnerable;
	SpriteRenderer m_SpriteRenderer;
	SpriteRenderer o_SpriteRenderer;

	IEnumerator VulnerableDeBuff() {
		yield return new WaitForSeconds (5f);
		vulnerable = false;
		m_SpriteRenderer.color = Color.white;
		Debug.Log("vulnerable = false!");
	}

	private void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "extraLife") {
			lives += 1;
			Destroy (other.gameObject);
		}
		else if (other.gameObject.tag == "bomb"){
			vulnerable = true;

			m_SpriteRenderer.color = Color.red;
			Debug.Log (vulnerable);
			Destroy (other.gameObject);
			StartCoroutine ("VulnerableDeBuff");
		}
		else if (other.gameObject.tag == "trap" && vulnerable == true) {
			setLives ();
		}
		else if (other.gameObject.tag == "newBomb") {
			Debug.Log ("Collision!!!");
			ParticleSystem explosion = other.gameObject.GetComponent<ParticleSystem>();
			explosion.Play();
			resetPosition ();
			Destroy (other.gameObject, explosion.main.duration);
		}
	}

	public void setLives(){

		lives -= 1;

		if ( lives <= 0 || vulnerable == true )
			{
				Debug.Log("End  of Game");
				SceneManager.LoadScene ("Lost");
			}
	}

	private void spawnDelay() {
		m_SpriteRenderer.enabled = true;
		transform.SetPositionAndRotation (new Vector3 (-5.49f, 0.8f, 0), Quaternion.identity);
		setLives ();
	}

	void resetPosition() {
		Debug.Log ("Died! LOL XD");
		m_SpriteRenderer.enabled = false;
		Invoke("spawnDelay", 2);
		


	}

	void cameraFollow () {
		MainCamera ();
	}

	void Start () {
		speed = 5.1f;
		rb = GetComponent<Rigidbody2D> ();
		lives = 3;
		vulnerable = false;
		m_SpriteRenderer = GetComponent<SpriteRenderer>();



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
