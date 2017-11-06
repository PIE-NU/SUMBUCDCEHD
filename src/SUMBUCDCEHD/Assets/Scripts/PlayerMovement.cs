using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Vector3 StartLocation;
	Rigidbody2D mRigidBody;
	SpriteRenderer mSpriteRenderer;
	Vector2 mLeftForce;
	Vector2 mRightForce;

	GameManager gm;
	// Use this for initialization
	void Start () {
		mRigidBody = GetComponent<Rigidbody2D> ();
		mSpriteRenderer = GetComponent<SpriteRenderer> ();
		mLeftForce = new Vector2 (-10.0f, 0f);
		mRightForce = new Vector2 (10.0f, 0f);
		gm = FindObjectOfType<GameManager> ();
		ResetPlayer ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			mRigidBody.AddForce (mLeftForce);
			mSpriteRenderer.flipX = true;
		} else if (Input.GetKey (KeyCode.D)) {
			mRigidBody.AddForce (mRightForce);
			mSpriteRenderer.flipX = false;
		}
	}

	void OnCollisionEnter2D(Collision2D c ) {
		if (c.gameObject.GetComponent<Enemy> ()) {
			Debug.Log ("You died!");
			ResetPlayer ();
			gm.ResetGame ();
		}
	}

	void ResetPlayer() {
		mRigidBody.position = StartLocation;
		mRigidBody.velocity = new Vector3 (0f, 0f, 0f);
	}
}
