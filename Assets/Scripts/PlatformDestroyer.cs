using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	private GameObject  PlatformDestractionPoint;
	private Transform Coin;

	// Use this for initialization
	void Start () {
		PlatformDestractionPoint = GameObject.Find ("PlatformDestractionPoint");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x < PlatformDestractionPoint.transform.position.x) {


			gameObject.SetActive (false);
			for(int i = 0; i< transform.childCount; i++){
				if(transform.GetChild(i).name == "Coin"){	
					Coin = transform.GetChild(i);
					Coin.gameObject.SetActive(false);
				}
			}


		}
	}
}
