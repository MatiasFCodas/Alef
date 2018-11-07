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
    public GameObject door;
    public AudioSource porta;
    public AudioSource feed;
    public AudioSource somPuzzle03;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {
            porta.Play();
            feed.Play();
            puzzleB_02 = true;
            player.SetActive(true);
           // cam_puzzle.SetActive(false);
			cam.Priority = 9;
            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;
            somPuzzle03.Play();
        }
    }
}
