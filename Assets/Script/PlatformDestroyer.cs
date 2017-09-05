using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject  PlatformDestractionPoint;

	// Use this for initialization
	void Start () {
		PlatformDestractionPoint = GameObject.Find ("PlatformDestactionPoint");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x < PlatformDestractionPoint.transform.position.x) {

			//Destroy (gameObject);

			gameObject.SetActive (false);



		}
	}
}
