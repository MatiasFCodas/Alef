using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleA_01 : MonoBehaviour {

    public bool puzzleA_01;

    public GameObject player;
    public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject face;
    public GameObject inicio;
    public GameObject instrucoes02;

    public AudioSource feed;
    public AudioSource som;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            feed.Play();

            instrucoes02.SetActive(false);

            puzzleA_01 = true;
            player.SetActive(true);
            // cam_puzzle.SetActive(false);
            cam.Priority = 9;

            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;
            som.Play();
        }
    }
}

