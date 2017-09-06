using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public bool IsGrounded;
	public GameManger GameMangment;
	public Rocket PlayerControler;

	void OnCollisionEenter2D(Collision2D other){
		if (other.collider.tag == "Ground") {
			IsGrounded = true;
		}

	}

	void OnCollisionStay2D(Collision2D other){
		if (other.collider.tag == "Ground") {
			IsGrounded = true;
		}

	}


	void OnCollisionExit2D(Collision2D other){
		if (other.collider.tag == "Ground") {
			IsGrounded = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Spike") {
			GameMangment.RestartGame ();
		
		}

		if (other.tag == "Saw") {
			PlayerControler.JumpSpeed = 8f;


		}
	}
}

