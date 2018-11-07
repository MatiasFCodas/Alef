using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPuzzle : MonoBehaviour {

    public GameObject player;
    public GameObject cam_puzzle;
    public GameObject interativo;

    public int puzzle01_A = 17;

	void Start () {
        interativo.GetComponent<move2>().enabled = false;
	}

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<CharController>().inPuzzle = true;
            cam_puzzle.SetActive(true);
            interativo.GetComponent<move2>().enabled = true;
        }
    }
}
