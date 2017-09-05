using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
	public Player plyerscript;
	private Rigidbody2D mybody;
	public float MoveSpeed;
	public float JumpSpeed;
	public float SpeedMultiPlier;
	public float SpeedIncreaceMileStone;
	private float SpeedMileStoneCount;


	// Use this for init ialization
	void Start () {
		mybody = GetComponent<Rigidbody2D > (); 
		SpeedMileStoneCount = SpeedIncreaceMileStone;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (transform.position.x > SpeedMileStoneCount) {
			SpeedMileStoneCount += SpeedIncreaceMileStone;
			SpeedIncreaceMileStone = SpeedIncreaceMileStone * SpeedMultiPlier;
			MoveSpeed = MoveSpeed * SpeedMultiPlier;
		}



		if ((Input.GetButton("Jump") || Input.GetMouseButton(0)) && plyerscript.IsGrounded) {
			mybody.velocity = new Vector3 (mybody.velocity.x, MoveSpeed, 0f);
		}

		if (plyerscript.IsGrounded == false) {
			transform.Rotate (Vector3.forward * -90 * Time.deltaTime);

		}
		mybody.velocity= new Vector3 (MoveSpeed, mybody.velocity.y, 0f);


}
}