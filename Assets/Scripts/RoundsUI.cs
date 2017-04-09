using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsUI : MonoBehaviour {

	public Text roundsText;

	// Update is called once per frame
	void Update () {
		roundsText.text = "Rounds : " +PlayerStats.Rounds.ToString ();
	}
}
