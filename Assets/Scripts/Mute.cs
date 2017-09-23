using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mute : MonoBehaviour {
	public Button MuteButton;
	public Button UnMuteButton;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey ("Mute")){
			if( PlayerPrefs.GetInt("Mute") == 1){
			AudioListener.pause = true;
			UnMuteButton.gameObject.SetActive (true);
			MuteButton.gameObject.SetActive (false);
			}
		}
	}
	
	// Update is called once per frame
	
	public void Mutebut(){

		PlayerPrefs.SetInt ("Mute", 1);
		AudioListener.pause = true;
	}
	public void UnMutebut(){

		PlayerPrefs.SetInt ("Mute", 0);
		AudioListener.pause = false;
	}
}
