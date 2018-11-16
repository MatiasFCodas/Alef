using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleB_01 : MonoBehaviour {

    public bool puzzleB_01 = false;

    public GameObject player;
	public CinemachineVirtualCamera cam;
    public GameObject face;
    public GameObject inicio;

    public AudioSource feed;

    public move2 movcubo;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face"))
        {

            feed.Play();
            puzzleB_01 = true;
			cam.Priority = 9;

            movcubo.canMove = false;

            player.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = false;
            inicio.SetActive(false);
            face.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
