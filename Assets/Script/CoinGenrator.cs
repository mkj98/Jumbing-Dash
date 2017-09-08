using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenrator : MonoBehaviour {
	public ObjectPooler CoinPool;
	public float DistanceBetwenCoins;

	public void SpawnCoins(Vector3 StartPosition){

		GameObject Coin1 = CoinPool.GetPooledObjects ();
		Coin1.transform.position = StartPosition;
		Coin1.SetActive (true);

		GameObject Coin2 = CoinPool.GetPooledObjects ();
		Coin2.transform.position = new Vector3 (StartPosition.x - DistanceBetwenCoins , StartPosition.y, StartPosition.z) ;
		Coin2.SetActive (true);

		GameObject Coin3 = CoinPool.GetPooledObjects ();
		Coin3.transform.position = new Vector3 (StartPosition.x + DistanceBetwenCoins , StartPosition.y, StartPosition.z) ;
		Coin3.SetActive (true);


	}

}
