using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharcterScript : MonoBehaviour {
	public GameObject CharcterView;
	private  Vector3 StartupPosition;
	public Sprite[] PlayerSkins;
    private int skinIndex;
    private int ChosenCharcter;
	private ParamaterPasser ParamaterPasser;
    public int SkinIndex ;

    // Use this for initialization
    void Start () {
		ParamaterPasser = FindObjectOfType <ParamaterPasser>();
		StartupPosition = CharcterView.transform.position;

		if(PlayerPrefs.HasKey ("ChosenSkin")){
			ParamaterPasser.ChosenSkin = PlayerSkins[PlayerPrefs.GetInt("ChosenSkin")];

		}
}
	
	// Update is called once per frame
	//void Update () {
		
	public void SelectCharcter(){
		ChosenCharcter = SkinIndex ;
		PlayerPrefs.SetInt("ChosenSkin", ChosenCharcter);
		Debug.Log(ChosenCharcter );
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
