using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour {

	public GameObject enemyPrefab;
	float timeSinceLastEnemy = 0f;
	public float addEnemyTime = 10.0f;
	public int currentEnemies = 0;
	public int maxEnemies = 5;

	// Use this for initialization
	void Start () {
		resetGame ();
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastEnemy += Time.deltaTime;
		if (timeSinceLastEnemy > addEnemyTime) {
			addEnemy ();
		}
	}

	public void resetGame() {
		enemy[] allEnemies = FindObjectsOfType<enemy> ();
		foreach (enemy e in allEnemies) {
			Destroy (e.gameObject);
		}
		currentEnemies = 0;
		addEnemy ();
	}

	void addEnemy() {
		if (currentEnemies < maxEnemies) {
			GameObject enemy = Instantiate (enemyPrefab, new Vector3 (0f, 2f, 0f), Quaternion.identity);
			currentEnemies += 1;
		}
		timeSinceLastEnemy = 0f;
	}
}
