using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenrator : MonoBehaviour {

	public Transform GenrationPoint;

	public ObjectPooler[] objectpools;
	private int PlatformSelector;
	private float[] PlatformsWidths;
	private  int distancebetween;

	const  int distancebetweenMax = 3;
	const  int distancebetweenMin = 6;

	// Use this for initialization
	void Start () {
		PlatformsWidths = new float[objectpools.Length];
		for ( int i = 0; i < objectpools.Length; i++) {

			PlatformsWidths [i] = objectpools [i].PooledObject.GetComponent<BoxCollider2D> ().size.x;
		}
		 
	}
	
	// Update is called once per frame
	void Update () {

		distancebetween = Random.Range(distancebetweenMin, distancebetweenMax);

		if (transform.position.x < GenrationPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + (PlatformsWidths[PlatformSelector] / 2 ) + distancebetween ,  transform.position.y, 0f);

			PlatformSelector = Random.Range (0, objectpools.Length);


			GameObject NewPlatform = objectpools[PlatformSelector].GetPooledObjects ();
			NewPlatform.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
			NewPlatform.transform.rotation = transform.rotation;
			NewPlatform.SetActive (true);
			transform.position = new Vector3 (transform.position.x + (PlatformsWidths[PlatformSelector] / 2 )  ,  transform.position.y, 0f);

		}
	}
}
