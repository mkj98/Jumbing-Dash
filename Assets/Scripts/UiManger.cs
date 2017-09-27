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
	public int SkinIndex;
	private GameManger gamemangment;
	private PlayerController Player;
	private ScoreManger scoremanger;
	
	private float Coins;
	void Start(){
		gamemangment = FindObjectOfType <GameManger> ();
		scoremanger = FindObjectOfType <ScoreManger> ();
		
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
