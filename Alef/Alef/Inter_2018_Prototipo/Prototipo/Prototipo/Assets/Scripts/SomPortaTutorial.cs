using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomPortaTutorial : MonoBehaviour {

    public AudioSource somPorta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SomAbriPorta()
    {
        somPorta.Play();
    }
}
