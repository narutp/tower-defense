using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool GameIsOver;
	public GameObject gameOverUI;
	public GameObject winUI;
	public AudioClip gameOverClip;
	public AudioSource gameOverSource;

	void Start() {
		GameIsOver = false;
		gameOverSource = GetComponent<AudioSource> ();
	}

	void Update () {
		if (GameIsOver) {
			return;
		}
		if (PlayerStats.Lives <= 0) {
			EndGame ();
		}
		if (PlayerStats.Rounds > 10) {
			WinGame ();
		}
	}

	void EndGame() {
		gameOverSource.PlayOneShot (gameOverClip, 1f);
		GameIsOver = true;
		gameOverUI.SetActive (true);
	}

	void WinGame() {
		gameOverSource.PlayOneShot (gameOverClip, 1f);
		GameIsOver = true;
		winUI.SetActive (true);

	}
}
