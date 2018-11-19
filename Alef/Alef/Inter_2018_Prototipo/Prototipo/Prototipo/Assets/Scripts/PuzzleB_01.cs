﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleB_01 : MonoBehaviour {

    public bool puzzleB_01 = false;

    public GameObject player;
	public CinemachineVirtualCamera cam;
    public GameObject face;
    public GameObject inicio;

    public GameObject brilhinhoFinal;

    public AudioSource feed;

    public move2 movcubo;
    public AudioSource narracao;
    public float time;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {

            cam.Priority = 9;
            feed.Play();
            puzzleB_01 = true;
            player.GetComponent<CharController>().inPuzzle = true;
            movcubo.canMove = false;
            inicio.SetActive(false);
            face.GetComponent<BoxCollider>().enabled = false;
            time = Time.fixedDeltaTime;
            time++;

            brilhinhoFinal.SetActive(true);
            if ( time >= 1)
            {
                narracao.Play();
            }
        }
    }
}