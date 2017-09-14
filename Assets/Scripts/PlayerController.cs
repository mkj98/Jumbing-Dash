using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D mybody;
	public float MoveSpeed;
	public float JumpSpeed;
	public float SpeedMultiPlier;
	public float SpeedIncreaceMileStone;
	private float SpeedMileStoneCount;
	private Vector3 JumpRotate = Vector3.forward  ;
	private bool IsGrounded;
	private BoxCollider2D BoxCollider;
	private float Interval;
	public LayerMask Ground;

	// Use this for init ialization
	void Start () {
		mybody = GetComponent<Rigidbody2D > (); 
		BoxCollider = GetComponent <BoxCollider2D > ();
		SpeedMileStoneCount = SpeedIncreaceMileStone;
	
	}
	
	// Update is called once per frame




	void FixedUpdate () {
		IsGrounded = Physics2D.IsTouchingLayers (BoxCollider, Ground);

		if (transform.position.x > SpeedMileStoneCount) {
			SpeedMileStoneCount += SpeedIncreaceMileStone;
			SpeedIncreaceMileStone = SpeedIncreaceMileStone * SpeedMultiPlier;
			MoveSpeed = MoveSpeed * SpeedMultiPlier;

		}



		if ((Input.GetButton("Jump") || Input.GetMouseButton(0)) && IsGrounded) {
			mybody.velocity = new Vector3 (mybody.velocity.x, JumpSpeed , 0f);
		}else if (IsGrounded == false) {
			transform.Rotate (JumpRotate * -140 * Time.deltaTime);

		}

			mybody.velocity = new Vector3 (MoveSpeed, mybody.velocity.y, 0f);

	

}
}