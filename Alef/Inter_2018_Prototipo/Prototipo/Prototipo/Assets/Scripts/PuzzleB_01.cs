using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleB_01 : MonoBehaviour {

    public bool puzzleB_01 = false;

    public GameObject door;
    public GameObject player;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject face;
    public GameObject inicio;

    public AudioSource feed;



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

            feed.Play();
            puzzleB_01 = true;
            door.SetActive(false);
           // cam_puzzle.SetActive(false);
			cam.Priority = 9;
            player.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            interativo.GetComponent<move2>().enabled = false;
            face.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
