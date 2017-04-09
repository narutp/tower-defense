using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;
	public Wave[] waves;
	public Transform enemyPrefab;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;
	private float countdown = 5f;
	private int waveIndex = 0;
	public Text waveCountdownText;

	void Update() {
		if (EnemiesAlive > 0) {
			return;
		}
		if (countdown <= 0f) {
			PlayerStats.Money += PlayerStats.Rounds * 10;
			PlayerStats.Rounds++;
			StartCoroutine (SpawnWave ());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);
		waveCountdownText.text = string.Format ("{0:00.00}", countdown);
	}	

	IEnumerator SpawnWave() {
		Wave wave = waves [waveIndex];
		EnemiesAlive = wave.count;
		for (int i = 0; i < wave.count; i++) {
			SpawnEnemy (wave.enemy);
			yield return new WaitForSeconds (1/wave.rate);
		}
		waveIndex++;
	}

	void SpawnEnemy(GameObject enemy) {
		Instantiate (enemy, spawnPoint.position,Quaternion.Euler(new Vector3(180,0,0)));
	}

}