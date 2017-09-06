using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

	public Transform PlatformGenrator;
	private Vector3 PlatformGenratorSpownPoint;
	public Transform Camera;
	private Vector3 CameraSpownPoint;


	public Rocket player;
	private Vector3 PlayerSpownPoint;
	private ScoreManger Scoremangment;
	private PlatformDestroyer[] platformslist;

	// Use this for initialization
	void Start () {
		PlatformGenratorSpownPoint = PlatformGenrator.position;
		PlayerSpownPoint = player.transform.position;
		CameraSpownPoint = Camera.position;
		Scoremangment = FindObjectOfType<ScoreManger > ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RestartGame(){

		StartCoroutine ("RestartGameCo");

	}

	public IEnumerator RestartGameCo(){
		Scoremangment.ScoreIncreaseing = false;
		player.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformslist = FindObjectsOfType <PlatformDestroyer> ();

		for (int i = 0; i < platformslist.Length; i++) {
			platformslist [i].gameObject.SetActive (false);
		}

		Camera.position = CameraSpownPoint;
		player.transform.position = PlayerSpownPoint;
		PlatformGenrator.position = PlatformGenratorSpownPoint;
		player.SpeedIncreaceMileStone = 200f;
		player.MoveSpeed = 8f;
		player.JumpSpeed = 10f; 
		player.gameObject.SetActive (true);
		Scoremangment.ScoreCounter = 0;


	}


}
