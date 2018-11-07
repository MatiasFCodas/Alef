using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour {


    public GameObject player;
    public GameObject restart;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = restart.transform.position;
    }
}
