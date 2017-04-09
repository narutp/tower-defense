using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickButton : MonoBehaviour {

	AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();	
	}

	public void onClick() {
		source.PlayOneShot (clip);
	}

}
