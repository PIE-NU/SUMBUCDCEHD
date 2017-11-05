using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

	public Vector3 startLocation;
	Rigidbody2D m_rigid_body;
	SpriteRenderer m_sprite_renderer;
	Vector2 m_left_force;
	Vector2 m_right_force;

	game_manager gm;
	// Use this for initialization
	void Start () {
		m_rigid_body = GetComponent<Rigidbody2D> ();
		m_sprite_renderer = GetComponent<SpriteRenderer> ();
		m_left_force = new Vector2 (-10.0f, 0f);
		m_right_force = new Vector2 (10.0f, 0f);
		gm = FindObjectOfType<game_manager> ();
		resetPlayer ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			m_rigid_body.AddForce (m_left_force);
			m_sprite_renderer.flipX = true;
		} else if (Input.GetKey (KeyCode.D)) {
			m_rigid_body.AddForce (m_right_force);
			m_sprite_renderer.flipX = false;
		}
	}

	virtual internal void OnCollisionEnter2D(Collision2D c ) {
		if (c.gameObject.GetComponent<enemy> ()) {
			Debug.Log ("You died!");
			resetPlayer ();
			gm.resetGame ();
		}
	}

	void resetPlayer() {
		m_rigid_body.position = startLocation;
		m_rigid_body.velocity = new Vector3 (0f, 0f, 0f);
	}
}
