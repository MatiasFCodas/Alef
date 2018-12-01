using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveagua : MonoBehaviour {

	private Renderer agua;
	// Use this for initialization
	void Start () {
		agua = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		agua.material.mainTextureOffset += new Vector2(.002f, .005f);


	}
}
