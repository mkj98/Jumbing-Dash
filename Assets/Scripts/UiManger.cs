using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManger : MonoBehaviour {
	public GameObject DeathMenu;
	public GameObject PauseButton;
	public Text Dm_TimerText;
	public GameObject  Dm_RestartButton;
	public int ChosenCharcter;
	
	private GameManger gamemangment;
	private PlayerController Player;
	private ScoreManger scoremanger;
	private Dm_timer Dm_timer;
	private float Coins;
	void Start(){
		gamemangment = FindObjectOfType <GameManger> ();
		scoremanger = FindObjectOfType <ScoreManger> ();
		Dm_timer = FindObjectOfType<Dm_timer> ();
		
	}
	public void WachVideo(){


	}

	public void PayCoins(){
		Coins = scoremanger.CoinsCounter;
		if (Coins > 200f) {
			scoremanger.CoinsCounter -= 200f;
			scoremanger.CoinCollected (0);
			gamemangment.Continu();
			DeathMenu.SetActive (false);
			PauseButton.SetActive (true);
			Dm_TimerText.gameObject.SetActive (true);
			Dm_RestartButton.SetActive (false);
			Dm_timer.Interval = 5f;
		}

	}


	public void Resume(){

		gamemangment.Resume ();

	}
    public void ApplyCharcter(){
		PlayerPrefs.SetInt ("ChosenSkin", ChosenCharcter);
		//Player.MySprite = PlayerSkins[ChosenCharcter];
		Debug.Log(ChosenCharcter);
	}

	
}
