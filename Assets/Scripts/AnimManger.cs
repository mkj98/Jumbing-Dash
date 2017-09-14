using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManger : MonoBehaviour {
	public Animator myanim;
	private float Interval;
	public bool IsPlaying;
	// Use this for initialization
	void Start () {
		Interval = 0f;
		IsPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsPlaying) {

			Interval -= Time.deltaTime;

		}
		if (Interval <= 0) {
			myanim.SetBool ("IsPlaying", false);


		} 

	}
	public void Respown_Anim(){

		myanim.SetBool ("IsPlaying", true);		
		Interval = 2f;
		IsPlaying = true;



	}

}
