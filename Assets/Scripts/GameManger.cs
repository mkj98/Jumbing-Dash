using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManger : MonoBehaviour {
	public GameObject PauseButton;
	public Ads Ad;
	public PlayerController player;
	public GameObject DeathMenu;

	public AudioSource Music;
	//public Animator myanim;

	public AudioSource PlayerDieSfx;
	public ParticleSystem  PlyerDieParticle;
	
	static int Loses;
	private Vector3 PlayerSpownPoint;
	private ScoreManger Scoremangment;
	
	
	// Use this for initialization
	void Start () {
		
	
		
		
		
		Scoremangment = FindObjectOfType<ScoreManger> ();
		
		

	}

	

	public void PlayerDie(){
		//Instantiate (PlyerDieParticle, player.transform);
				

		StartCoroutine ("PlayerDieco");

	}

	public IEnumerator PlayerDieco(){
		if (Loses == 5) {
			Ad.ShowVideo ();
			Loses = 0;
		} else {
			Loses += 1;
			Debug.Log (Loses);
		}
		Scoremangment.ScoreIncreaseing = false;
		Music.Pause();
		PlayerDieSfx.Play ();
		player.gameObject.SetActive (false);
		Instantiate (PlyerDieParticle, player.transform.position, Scoremangment.transform.rotation);
		yield return new WaitForSeconds (1f);
		DeathMenu.gameObject.SetActive (true);
		PauseButton.SetActive (false);
		
	}

	
	


	
	





}
