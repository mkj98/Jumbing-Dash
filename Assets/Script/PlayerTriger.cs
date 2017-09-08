using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriger : MonoBehaviour {
	public GameManger GameMangment;
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Spike") {
			GameMangment.PlayerDie ();

		}



	}
}
