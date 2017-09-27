using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ch_coinPanel : MonoBehaviour {
	public TextMeshProUGUI CoinsText;

	void Update()
	{
		float f = PlayerPrefs.GetFloat("Coins",0f);
		CoinsText.text = f.ToString();
	}
	// Use this for initialization
	
	
}
