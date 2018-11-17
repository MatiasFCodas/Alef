using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleA_01 : MonoBehaviour {

    public bool puzzleA_01;

    public GameObject player;
    public CinemachineVirtualCamera cam;
    public GameObject face;
    public GameObject inicio;
    public GameObject inicio02;

    public GameObject brilhinhoFinal;

    public AudioSource feed;
    public AudioSource som;

    public move2 movcubo;
    

  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            feed.Play();

            puzzleA_01 = true;
            player.SetActive(true);
            cam.Priority = 9;

            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            inicio02.SetActive(true);
            movcubo.canMove = false;
            face.GetComponent<BoxCollider>().enabled = false;
            som.Play();
            brilhinhoFinal.SetActive(true);
        }
    }
}

