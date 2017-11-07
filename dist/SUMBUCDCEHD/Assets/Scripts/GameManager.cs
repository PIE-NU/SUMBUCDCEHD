using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Singleton (see: https://en.wikipedia.org/wiki/Singleton_pattern)
	public static GameManager Instance;

	[SerializeField] private GameObject m_EnemyPrefab;

	// Maximum number of enemies to allow in game at a given time
	private const int MaxEnemies = 5;

	// Current amount of enemies in the game
	private int m_CurrentEnemies = 0;

	// Time since the last enemy was spawned
	private float m_TimeSinceLastEnemy = 0;

	// How frequently an enemy should spawn
	private float m_AddEnemyTime = 10;

	// Resets the game such that there is only one enemy
	public void ResetGame()
	{
		foreach (var e in FindObjectsOfType<Enemy>())
		{
			Destroy(e.gameObject);
		}
		m_CurrentEnemies = 0;
		m_TimeSinceLastEnemy = 0;
		AddEnemy();
	}

	// Called upon initialization
	private void Awake()
	{
		// Set the singleton instance
		if (Instance == null)
			Instance = this;

		// Reset the game to its initial state
		ResetGame();
	}

	// Called once per frame
	private void Update()
	{
		//...
	}

	// Adds an enemy to the game
	private void AddEnemy()
	{
		//...
	}
}
