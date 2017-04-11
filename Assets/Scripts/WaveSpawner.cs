using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 10;
	public Wave[] waves;
	public Transform enemyPrefab;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;
	private float countdown = 5f;
	private int waveIndex = 0;
	public Text waveCountdownText;
	private bool isCountdown = true;
	public Wave wave;

	void Start() {
		wave = waves [waveIndex];
		EnemiesAlive = wave.count;
	}

	void Update() {

		if (EnemiesAlive > 0 && !isCountdown) {
			return;
		}

		if (EnemiesAlive <= 0) {
			PlayerStats.Rounds++;
			PlayerStats.Money += PlayerStats.Rounds * 10;
			wave = waves [waveIndex];
			EnemiesAlive = wave.count;
			isCountdown = true;
		}

		if (countdown <= 0f) {
			isCountdown = false;
			waveIndex++;
			Debug.Log (wave.count);
			Debug.Log(EnemiesAlive);
			StartCoroutine (SpawnWave ());
			countdown = timeBetweenWaves;
			return;
		}

		if(isCountdown)
			countdown -= Time.deltaTime;

		countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);
		waveCountdownText.text = string.Format ("{0:00.00}", countdown);
	}	

	IEnumerator SpawnWave() {
		Debug.Log ("INININININININ");
		for (int i = 0; i < wave.count; i++) {
			SpawnEnemy (wave.enemy);
			yield return new WaitForSeconds (1/wave.rate);
		}
	}

	void SpawnEnemy(GameObject enemy) {
		Instantiate (enemy, spawnPoint.position,Quaternion.Euler(new Vector3(180,0,0)));
	}

}