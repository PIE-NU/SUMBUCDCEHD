using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject EnemyPrefab;
	float timeSinceLastEnemy = 0f;
	public float AddEnemyTime = 10.0f;

	int currentEnemies = 0;
	public int MaxEnemies = 5;

	// Use this for initialization
	void Start () {
		ResetGame ();
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastEnemy += Time.deltaTime;
		if (timeSinceLastEnemy > AddEnemyTime) {
			AddEnemy ();
		}
	}

	public void ResetGame() {
		Enemy[] allEnemies = FindObjectsOfType<Enemy> ();
		foreach (Enemy e in allEnemies) {
			Destroy (e.gameObject);
		}
		currentEnemies = 0;
		AddEnemy ();
	}

	void AddEnemy() {
		if (currentEnemies < MaxEnemies) {
			Instantiate (EnemyPrefab, new Vector3 (0f, 2f, 0f), Quaternion.identity);
			currentEnemies += 1;
		}
		timeSinceLastEnemy = 0f;
	}
}
