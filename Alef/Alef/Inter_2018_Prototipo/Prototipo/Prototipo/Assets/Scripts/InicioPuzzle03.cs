using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class InicioPuzzle03 : MonoBehaviour {

    public GameObject player;
    public GameObject cam_puzzle;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject puzzleB;
    public int puzzle02_C = 22;


    void Start()
    {
        interativo.GetComponent<move2>().enabled = false;
    }

    private void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
;
            player.GetComponent<CharController>().inPuzzle = true;
           // cam_puzzle.SetActive(true);
			cam.Priority = 12;
            interativo.GetComponent<move2>().enabled = true;
            interativo.GetComponent<move2>().maxMov = puzzle02_C;
        }
    }
}
