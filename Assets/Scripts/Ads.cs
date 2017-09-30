using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {
	public ScoreManger Score;
	static bool IsRewarded;
	public  void ShowVideo (){
			if(Advertisement.IsReady()){
				Advertisement.Show("", new ShowOptions(){resultCallback = HandleShowResult});
				IsRewarded = false;
			}
		
	}



	public  void ShowRewardedVideo (){
		
    
	}

	void HandleShowResult (ShowResult result){
    
		switch(result){
			case ShowResult.Finished:
				Debug.Log("Add Finshed");
				if(IsRewarded)Debug.Log(IsRewarded);
			break;
			
			case ShowResult.Skipped:
				Debug.Log("Add Was Skipped");
			break;

			case ShowResult.Failed:
				Debug.Log("Add Failed");
			break;

		}

	}

}
