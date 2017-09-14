using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dm_timer : MonoBehaviour {

	public Text Dm_TimerText;
	public GameObject  Dm_RestartButton;
	public  float Interval;

	// Use this for initialization
	void Start () {
		Interval = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		Interval -= Time.deltaTime;
		Dm_TimerText.text = Interval.ToString ("f0");

		if (Interval <= 0) {

			Dm_TimerText.gameObject.SetActive (false);
			Dm_RestartButton.SetActive (true);



		}

	}
}
