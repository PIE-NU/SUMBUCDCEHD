using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{	
	// Force to add when moving the player in a given direction
	[SerializeField] private Vector2 m_Force;

	// Starting location of the player
	[SerializeField] private Vector3 m_StartLocation;

	// Cached components
	private Rigidbody2D m_RigidBody;
	private SpriteRenderer m_SpriteRenderer;

	// Initialize cached components and reset player
	private void Start()
	{
		m_RigidBody = GetComponent<Rigidbody2D>();
		m_SpriteRenderer = GetComponent<SpriteRenderer>();
		ResetPlayer();
	}

	// Called once per frame
	private void Update()
	{
		//...
	}

	// Called when the player's collider overlaps c's collider
	private void OnCollisionEnter2D(Collision2D c)
	{
		//...
	}

	// Return the player to its initial state
	private void ResetPlayer()
	{
		m_RigidBody.position = m_StartLocation;
		m_RigidBody.velocity = new Vector3(0f, 0f, 0f);
	}
}
