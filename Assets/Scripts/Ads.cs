using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Ads : MonoBehaviour {
	public ScoreManger Score;

	public  void ShowVideo (){

		ShowOptions options = new ShowOptions();
		options.resultCallback = HandleShowResult;
		Advertisement.Initialize ("1564057");
		try {

			Advertisement.Show();
		} catch (System.Exception ex) {
			
		}
		Advertisement.Show();
	}



	public  void ShowRewardedVideo (){
		
    ShowOptions options = new ShowOptions();
    options.resultCallback = HandleShowResult;
		Advertisement.Initialize ("1564057");
    Advertisement.Show("rewardedVideo", options);
}

void HandleShowResult (ShowResult result){
    
		if(result == ShowResult.Finished) {
        //Debug.Log("Video completed - Offer a reward to the player");
			Score.DoubleCoins();
		

    }else if(result == ShowResult.Skipped) {
        Debug.LogWarning("Video was skipped - Do NOT reward the player");

    }else if(result == ShowResult.Failed) {
        Debug.LogError("Video failed to show");
    }
}
}
