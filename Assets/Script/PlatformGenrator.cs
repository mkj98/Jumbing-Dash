using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenrator : MonoBehaviour {

	//public GameObject[] Platforms;
	public Transform GenrationPoint;
	public float distancebetween;
	public ObjectPooler[] objectpools;

	private int PlatformSelector;
	private float[] PlatformsWidths;


	// Use this for initialization
	void Start () {
		PlatformsWidths = new float[objectpools.Length];
		for ( int i = 0; i < objectpools.Length; i++) {

			PlatformsWidths [i] = objectpools [i].PooledObject.transform.localScale.x;
		}
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < GenrationPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + (PlatformsWidths[PlatformSelector] / 2 ) + 10f ,  transform.position.y, transform.position.x);

			PlatformSelector = Random.Range (0, objectpools.Length);

			//Instantiate (Platforms[PlatformSelector], transform.position, transform.rotation);

			GameObject NewPlatform = objectpools[PlatformSelector].GetPooledObjects ();
			NewPlatform.transform.position = transform.position;
			NewPlatform.transform.rotation = transform.rotation;
			NewPlatform.SetActive (true);
			transform.position = new Vector3 (transform.position.x + (PlatformsWidths[PlatformSelector] / 2 )  ,  transform.position.y, transform.position.x);

		}
	}
}
