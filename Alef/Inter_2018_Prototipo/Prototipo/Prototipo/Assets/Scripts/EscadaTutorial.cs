using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscadaTutorial : MonoBehaviour {

    public GameObject puzzle;
    public Animator animPlataforma;
    public Animator animEscada;

    public AudioSource stairSource;
    public AudioSource platSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(puzzle.GetComponent<PuzzleA_01>().puzzleA_01 == true)
        {
            animPlataforma.SetTrigger("AbriPlataforma");
        }
	}

    public void AbreEscada()
    {
        animEscada.SetTrigger("AbriEscada");
        stairSource.Play();
    }

    public void SomPlataforma()
    {
        platSource.Play();
    }
}
