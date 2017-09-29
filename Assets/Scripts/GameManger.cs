using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManger : MonoBehaviour {

	public Transform PlatformGenrator;
	public Transform Camera;
	public Ads Ad;
	public PlayerController player;
	public GameObject DeathMenu;
	public float MoveAhead;
	public AudioSource Music;
	public GameObject PauseButton;
	public Animator myanim;
	public bool IsPlaying;
	public AudioSource PlayerDieSfx;
	public ParticleSystem  PlyerDieParticle;
	private float Interval;
	static int Loses;
	private Vector3 PlayerSpownPoint;
	private ScoreManger Scoremangment;
	private PlatformDestroyer[] platformslist;
	private Vector3 PlatformGenratorSpownPoint;
	private Vector3 CameraSpownPoint;
	// Use this for initialization
	void Start () {
		
		PlatformGenratorSpownPoint = PlatformGenrator.position;
		PlayerSpownPoint = player.transform.position;
		CameraSpownPoint = Camera.position;
		
		Scoremangment = FindObjectOfType<ScoreManger> ();
		Interval = 1f;
		IsPlaying = false;

	}

	void Update(){

		if (IsPlaying) {

			Interval -= Time.deltaTime;

		}
		if (Interval <= 0 && player.gameObject.activeInHierarchy) {
			myanim.SetBool ("IsPlaying", false);
			IsPlaying = true;

		} 



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

	public void Continu(){
		platformslist = FindObjectsOfType <PlatformDestroyer> ();

		for (int i = 0; i < platformslist.Length; i++) {
			platformslist [i].gameObject.SetActive (false);
		}
		Camera.position = CameraSpownPoint;
		player.transform.position = PlayerSpownPoint;
		PlatformGenrator.position = PlatformGenratorSpownPoint;
		player.gameObject.SetActive (true);
		Scoremangment.ScoreIncreaseing = true;
		DeathMenu.gameObject.SetActive (false);
		Music.Play ();

	}


	public void  Reset(){

		platformslist = FindObjectsOfType <PlatformDestroyer> ();

		for (int i = 0; i < platformslist.Length; i++) {
			platformslist [i].gameObject.SetActive (false);
		}

		Camera.position = CameraSpownPoint;
		player.transform.position = PlayerSpownPoint;
		PlatformGenrator.position = PlatformGenratorSpownPoint;
		player.SpeedIncreaceMileStone = 200f;
		player.MoveSpeed = 8f;
		player.gameObject.SetActive (true);
		Scoremangment.ScoreCounter = 0;
		Scoremangment.ScoreIncreaseing = true;
		Music.pitch = 1f;
		Music.Play ();
		DeathMenu.gameObject.SetActive (false);



	}

	public void Resume(){


		player.gameObject.SetActive (true);
		Music.Play ();

	}

	public void Respown_Anim(){

		myanim.SetBool ("IsPlaying", true);		
		Interval = 2f;
		IsPlaying = true;



	}

}
