using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	private GameObject  PlatformDestractionPoint;

	// Use this for initialization
	void Start () {
		PlatformDestractionPoint = GameObject.Find ("PlatformDestractionPoint");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x < PlatformDestractionPoint.transform.position.x) {


			gameObject.SetActive (false);



		}
	}
}
