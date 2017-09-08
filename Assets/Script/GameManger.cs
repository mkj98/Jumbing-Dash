using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

	public Transform PlatformGenrator;
	public Transform Camera;
	public PlayerController player;
	public DeathMenu deathmenu;
	public PauseMenu pausemenu;
	public float MoveAhead;
	public AudioSource Music;
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
	}
	


	public void PlayerDie(){

		StartCoroutine ("PlayerDieco");

	}

	public IEnumerator PlayerDieco(){
		Scoremangment.ScoreIncreaseing = false;
		player.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		deathmenu.gameObject.SetActive (true);
	


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
		deathmenu.gameObject.SetActive (false);
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
		deathmenu.gameObject.SetActive (false);



	}

	public void Resume(){

		pausemenu.gameObject.SetActive (false);
		player.gameObject.SetActive (true);
		Music.Play ();

	}
}
