using UnityEngine;

public class CameraControler : MonoBehaviour {
	public GameObject Target;
	private Vector3 TargetPosition;

		// Update is called once per frame
	void Update () {

		TargetPosition = new Vector3 (Target.transform.position.x + 5f , transform.position.y, transform.position.z);
		transform.position = TargetPosition ;

	}
}
