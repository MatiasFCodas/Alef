using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleC_02 : MonoBehaviour {

    public GameObject player;
    public GameObject cam_puzzle;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject face;
    public GameObject inicio;
    public GameObject door;

    public GameObject brilhinhoFinal;

    public AudioSource porta;
    public AudioSource feed;
    public AudioSource narrativa;

    public bool puzzleC_02 = false;

    public move2 movcubo;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            porta.Play();
            feed.Play();
			cam.Priority = 9;

            movcubo.canMove = false;

            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;

            brilhinhoFinal.SetActive(true);

            puzzleC_02 = true;

            narrativa.Play();
        }
    }
}
