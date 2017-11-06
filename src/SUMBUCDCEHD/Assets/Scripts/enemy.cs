using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rigidBody;
	public float speed;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		float xForce = Random.Range (-1f, 1f) * speed;
		float yForce = Random.Range (-1f, 1f) * speed;
		Vector2 initialForce = new Vector2 (xForce, yForce);
		rigidBody.AddForce(initialForce);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
