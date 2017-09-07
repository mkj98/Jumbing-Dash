using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {
	public GameObject PooledObject;
	const int PooledAmount = 2;

	List<GameObject> pooledObjects; 

	// Use this for initialization
	void Start () {
		pooledObjects = new List<GameObject> ();

		for (int i = 0; i < PooledAmount; i++) {
			GameObject obj = (GameObject) Instantiate (PooledObject);
			obj.SetActive (false);
			pooledObjects.Add (obj);

		}
	}
	
	public GameObject GetPooledObjects(){
		for (int i = 0; i < pooledObjects.Count; i++) {

			if (!pooledObjects [i].activeInHierarchy) {
				 
				return pooledObjects [i];

			}

		}

		GameObject obj = (GameObject) Instantiate (PooledObject);
		obj.SetActive (false);
		pooledObjects.Add (obj);
		return obj;

	}
}
