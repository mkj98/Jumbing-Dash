using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour {

	public AudioSource Music;

	// Use this for initialization
	void Start () {
		Music = GetComponent <AudioSource > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Music.pitch < 1.6) {

			Music.pitch += 0.0001f * (Time.deltaTime);
		}
		Debug.Log (Music.pitch);
	}
}
