using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManger : MonoBehaviour {

	public Text ScoreText;
	public TextMeshProUGUI d_ScoreText;
	public Text HighScoreText;
	public TextMeshProUGUI d_HiScoreText;
	public TextMeshProUGUI Dm_CoinsText;
	public Text CoinsText;
	public Button DoublecoinsButton;
	public float ScoreCounter;
	public float HighScoreCounter;
	public float PointPerScound;
	public float CoinsCounter;
	static float Dm_CoinsCounter;
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
		d_ScoreText.text = Mathf.Round(ScoreCounter).ToString();
		d_HiScoreText.text = Mathf.Round(HighScoreCounter).ToString();
		HighScoreText.text = "HighScore: " + Mathf.Round (HighScoreCounter);
	}
	public void AddScore(int ScoreToAdd){
		ScoreCounter += ScoreToAdd;
	}
	public void CoinCollected(int coins){
		CoinsCounter += coins;
		Dm_CoinsCounter += coins;
		CoinsText.text = "" + CoinsCounter ;
		Dm_CoinsText.text = "" + Dm_CoinsCounter ;
		PlayerPrefs.SetFloat ("Coins", CoinsCounter);


	}

	public void DoubleCoins(){
		float coins = PlayerPrefs.GetFloat ("Coins") + Dm_CoinsCounter;

		PlayerPrefs.SetFloat ("Coins", coins);
		DoublecoinsButton.gameObject.SetActive (false);


	}
}
