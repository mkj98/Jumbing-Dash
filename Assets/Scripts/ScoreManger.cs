using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

	public Text ScoreText;
	public Text HighScoreText;
	public Text CoinsText;
	public float ScoreCounter;
	public float HighScoreCounter;
	public float PointPerScound;
	public float CoinsCounter;
	public bool ScoreIncreaseing;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.HasKey ("Coins")) {

			CoinsCounter = PlayerPrefs.GetFloat ("Coins");
			CoinsText.text = "" + CoinsCounter ;

		}
		if (PlayerPrefs.HasKey ("HighScore")) {

			HighScoreCounter = PlayerPrefs.GetFloat ("HighScore");
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (ScoreIncreaseing) {
			ScoreCounter += PointPerScound * Time.deltaTime;
		}

		if (ScoreCounter > HighScoreCounter) {

			HighScoreCounter = ScoreCounter;
			PlayerPrefs.SetFloat ("HighScore", HighScoreCounter);
		}
		ScoreText.text = "Score: " + Mathf.Round( ScoreCounter);
		HighScoreText.text = "HighScore: " + Mathf.Round (HighScoreCounter);
	}
	public void AddScore(int ScoreToAdd){
		ScoreCounter += ScoreToAdd;
	}
	public void CoinCollected(int coins){
		CoinsCounter += coins;
		CoinsText.text = "" + CoinsCounter ;
		PlayerPrefs.SetFloat ("Coins", CoinsCounter);


	}
}
