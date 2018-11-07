﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleA_02 : MonoBehaviour {

    public bool puzzleA_02;
    public GameObject player;
    public GameObject cam_puzzle;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject face;
    public GameObject inicio;
    public GameObject door;
    public AudioSource feedFim;
    public AudioSource porta;
    public AudioSource somPuzzle02;


    // Use this for initialization
    void Start () {
        feedFim = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            porta.Play();
            feedFim.Play(0);
            puzzleA_02 = true;
            player.SetActive(true);
            //cam_puzzle.SetActive(false);
			cam.Priority = 9;
            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;
            somPuzzle02.Play();
        }
    }

}
