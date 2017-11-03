using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-10.0f, 0f));
			GetComponent<SpriteRenderer> ().flipX = true;
		} else if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (10.0f, 0f));	
			GetComponent<SpriteRenderer> ().flipX = false;
		}
	}
}
