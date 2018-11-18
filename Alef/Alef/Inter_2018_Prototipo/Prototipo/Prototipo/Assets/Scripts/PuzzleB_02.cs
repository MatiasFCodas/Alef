using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleB_02 : MonoBehaviour {

    public bool puzzleB_02;

    public GameObject player;
    public GameObject cam_puzzle;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject face;
    public GameObject inicio;
    public GameObject inicio03;
    public GameObject door;
    public AudioSource porta;
    public AudioSource feed;
    public AudioSource somPuzzle03;
    public AudioSource narracao;

    public GameObject brilhinhoFinal;

    public move2 movcubo;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            porta.Play();
            feed.Play();

            puzzleB_02 = true;
            movcubo.canMove = false;
            inicio.SetActive(false);
            inicio03.SetActive(true);
            brilhinhoFinal.SetActive(true);

            cam.Priority = 9;

            player.GetComponent<CharController>().inPuzzle = false;

            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;

            narracao.Play();

        }
    }
}
