using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		float xForce = Random.Range (-1f, 1f) * speed;
		float yForce = Random.Range (-1f, 1f) * speed;
		Vector2 initialForce = new Vector2 (xForce, yForce);
		rb.AddForce(initialForce);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
