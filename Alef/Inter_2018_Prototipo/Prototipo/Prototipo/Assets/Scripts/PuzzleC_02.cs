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

    public AudioSource porta;
    public AudioSource feed;

    public bool puzzleC_02 = false;

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

            player.SetActive(true);
           // cam_puzzle.SetActive(false);
			cam.Priority = 9;

            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;

            puzzleC_02 = true;
        }
    }
}
