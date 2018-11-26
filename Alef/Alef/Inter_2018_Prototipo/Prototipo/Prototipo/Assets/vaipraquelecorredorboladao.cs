using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class vaipraquelecorredorboladao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collider col)
	{
		if (col.CompareTag("Player"))
		{

			SceneManager.LoadScene(4);



		}



	}
}
