﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartOnClick : MonoBehaviour {

	public void LoadByIndex (int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}
}
