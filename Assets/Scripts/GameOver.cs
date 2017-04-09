using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text roundsText;

	void OnEnable() {
		roundsText.text = (PlayerStats.Rounds-1).ToString ();
	}

	public void Retry() {
		GameManager.GameIsOver = false;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu() {
		GameManager.GameIsOver = false;
		SceneManager.LoadScene ("Mainmenu");
	}
}
