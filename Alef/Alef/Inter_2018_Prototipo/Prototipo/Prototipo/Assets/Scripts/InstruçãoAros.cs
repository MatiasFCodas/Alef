using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstruçãoAros : MonoBehaviour {

    public GameObject instrucaoAro;
    public GameObject hitBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        instrucaoAro.SetActive(true);
    }

     void OnTriggerExit(Collider other)
    {
        instrucaoAro.SetActive(false);
        hitBox.SetActive(false);
    }
}
