using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralaxing : MonoBehaviour {
		public Transform[] Backgrounds;
		private float [] ParralaxScales;
		public float Smoothing = 1f;

		private Transform Cam;
		private Vector3 PreviousCamPos;

	 void Awake() {
		 Cam = Camera.main.transform ;
	 }
	

	
	// Use this for initialization
	void Start () {
		PreviousCamPos = Cam.position ;

		ParralaxScales = new float[Backgrounds.Length];

		for (int i = 0  ; i < Backgrounds.Length ;i++){
			ParralaxScales[i] = Backgrounds[i].position.z*-1;


		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Backgrounds.Length ; i++){
			float Parallx = (PreviousCamPos.x - Cam.position.x) * ParralaxScales[i];
			float BackgroundTargetPosX = Backgrounds[i].position.x + Parallx ;

			Vector3 BackgroundTargetPos = new Vector3 (BackgroundTargetPosX, Backgrounds[i].position.y, Backgrounds[i].position.z);
			Backgrounds[i].position = Vector3.Lerp (Backgrounds[i].position, BackgroundTargetPos, Smoothing * Time.deltaTime);
			PreviousCamPos = Cam.position ;
		}
	}
}
