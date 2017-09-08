using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class PauseMenu : MonoBehaviour {

	public GameManger gamemangment;
	public AudioSource BackGroundMusic;
	public PlayerController player;

	public void PauseButton(){
		player.gameObject.SetActive (false);
		gameObject.SetActive (true);
	}



	public void Restart(){
		BackGroundMusic.Pause ();
		gamemangment.Reset ();


	}

	public void Resume(){
		BackGroundMusic.Pause ();

		gamemangment.Resume ();
	}

	public void QuitToMain(){
		BackGroundMusic.Pause ();
		SceneManager.LoadScene (0);

	}
}
