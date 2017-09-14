using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	private ScoreManger scoremanger;
	const int ScoreToGive = 4;
	// Use this for initialization
	void Start () {
		scoremanger = FindObjectOfType<ScoreManger> ();
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "Player") {
			scoremanger.CoinCollected(1);
			scoremanger.AddScore(ScoreToGive);
			gameObject.SetActive(false);
		}

	}

}
