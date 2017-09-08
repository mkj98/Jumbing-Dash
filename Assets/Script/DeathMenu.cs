using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ; 
public class DeathMenu : MonoBehaviour {
	public GameManger gamemangment;
	public AudioSource BackGroundMusic;





	public void Restart(){
		
		BackGroundMusic.Pause ();
		gamemangment.Reset ();
	}

	public void Continu(){
		
		BackGroundMusic.Pause ();
		gamemangment.Continu ();
	}

	public void QuitToMain(){
		
		BackGroundMusic.Pause ();
		SceneManager.LoadScene (0);
	}

}
