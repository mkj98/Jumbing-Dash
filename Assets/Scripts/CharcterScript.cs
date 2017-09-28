using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharcterScript : MonoBehaviour {
	public GameObject CharcterView;
	private  Vector3 StartupPosition;
	public Sprite[] PlayerSkins;
	public Button BuyButton;
    private int skinIndex;
    private int ChosenCharcter;
	private int[] OwnedSkinIndexs;
	private ParamaterPasser ParamaterPasser;
    public int SkinIndex ;
	public BuySkin Buy;
    // Use this for initialization
    void Start () {
	
		OwnedSkinIndexs = PlayerPrefsX.GetIntArray("OwnedSkinIndexs",27,1);
		ParamaterPasser = FindObjectOfType <ParamaterPasser>();
		StartupPosition = CharcterView.transform.position;

		if(PlayerPrefs.HasKey ("ChosenSkin")){
			ParamaterPasser.ChosenSkin = PlayerSkins[PlayerPrefs.GetInt("ChosenSkin")];

		}
}
	
	// Update is called once per frame
	//void Update () {
		
	public void SelectCharcter(){
		OwnedSkinIndexs = PlayerPrefsX.GetIntArray("OwnedSkinIndexs",27,1);
		ChosenCharcter = SkinIndex ;
		BuyButton.gameObject.SetActive(false);
		Buy.ShowBuyBtn(ChosenCharcter);
		for(int i = 0 ; i < OwnedSkinIndexs.Length; i++){
			
			if(ChosenCharcter == OwnedSkinIndexs[i]){

				PlayerPrefs.SetInt("ChosenSkin", ChosenCharcter);
				BuyButton.gameObject.SetActive(true);
				Debug.Log(ChosenCharcter+ "--" + ChosenCharcter + "--" + OwnedSkinIndexs[i]);
			}
				
			
		}
		
		PlayerPrefs.SetInt("ChosenSkin", ChosenCharcter);
		
		CharcterView.SetActive (false);  
		CharcterView.GetComponent<SpriteRenderer > ().sprite = PlayerSkins[SkinIndex];
	
		CharcterView.transform.position = StartupPosition;
		CharcterView.transform.Rotate (0f, 0f, 10f);
		CharcterView.SetActive (true);
		
	}

	public void ApplayCharcter(){
		
		ParamaterPasser.ChosenSkin = PlayerSkins[PlayerPrefs.GetInt("ChosenSkin")];

	
	}
}
