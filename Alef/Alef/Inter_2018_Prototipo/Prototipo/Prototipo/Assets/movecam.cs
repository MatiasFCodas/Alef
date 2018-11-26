using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour {

	private Transform cam;

	void Start () {
		cam = GetComponent<Transform>();
	}
	

	void Update () {
		cam.Rotate(Vector3.up, .5f);
	}
}
