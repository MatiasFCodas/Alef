using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Deus : MonoBehaviour {

    public AudioSource falaDeus;
    public CinemachineFreeLook camDeus;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        falaDeus.Play();
        camDeus.Priority = 12;
    }
}
