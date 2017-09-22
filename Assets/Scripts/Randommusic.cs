using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randommusic : MonoBehaviour {
     public AudioClip[] MusicClips;
	 public AudioSource MusicPlayer;

	// Use this for initialization
	void Start () {
		MusicPlayer.Stop ();
		int i =  Random.Range(0,MusicClips.Length);
		Debug.Log(i);
		MusicPlayer.clip = MusicClips[i];
		MusicPlayer.Play();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
