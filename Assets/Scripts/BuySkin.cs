using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BuySkin : MonoBehaviour {
	private int[] Prisees;
	private int coins;
	static int SkinIndex;
	public TextMeshProUGUI BuybtnText;
	private int[] OwnedSkinIndexs;
	private List<int> OwnedSkinList;
	// Use this for initialization
	void Start () {
		
		
		Prisees = new int[] 
		{000,000,000,000,300,300,300,
		 500,500,500,500,500,500,500,
		 800,800,800,800,800,800,800,
		 1200,1200,1200,1200,1200,1200,1200,
		};
	}
	
	public void Buy(){
		OwnedSkinIndexs = PlayerPrefsX.GetIntArray("OwnedSkinIndexs",27,1);
		List<int> lst = new List<int>();
			lst.AddRange(OwnedSkinIndexs);
		coins = Mathf.RoundToInt(PlayerPrefs.GetFloat("Coins"));
		
		if(coins >= Prisees[SkinIndex]){
			lst.Add(SkinIndex);
			OwnedSkinIndexs = lst.ToArray();
			PlayerPrefsX.SetIntArray("OwnedSkinIndexs",OwnedSkinIndexs);
		
		}
	}
	
	public void ShowBuyBtn(int index){
		BuybtnText.text = "Buy  " + Prisees[index] + "  Coins";
		gameObject.SetActive(true);
		SkinIndex = index;
	}
	
}
