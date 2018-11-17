using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sala_Secreta : MonoBehaviour {

    public AudioSource porta;
    public bool abrirPorta = false;
    public GameObject puzzle3;
    public GameObject trigger;
    public GameObject doorSecreta;

	// Use this for initialization
	void Start () {
        porta = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (puzzle3.GetComponent<PuzzleC_02>().puzzleC_02 == true)
        {
            abrirPorta = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (abrirPorta == true){
            porta.Play();
            doorSecreta.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (abrirPorta == true)
        {
            trigger.SetActive(false);
        }
    }
}
