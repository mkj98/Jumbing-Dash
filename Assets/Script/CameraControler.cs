using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {
	public GameObject Target;

	public float FollwAhead;
	private Vector3 TargetPosition;
	public float Smothing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TargetPosition = new Vector3 (Target.transform.position.x, transform.position.y, transform.position.z);
		if (Target.transform.localScale.x > 0f) {
			TargetPosition = new Vector3 (TargetPosition.x + FollwAhead, TargetPosition.y, TargetPosition.z);
		} else {
			TargetPosition = new Vector3 (TargetPosition.x - FollwAhead, TargetPosition.y, TargetPosition.z);

		}
		transform.position = Vector3.Lerp (transform.position, TargetPosition, Smothing * Time.deltaTime);
	
	}
}
