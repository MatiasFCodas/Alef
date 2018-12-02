using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class InicioPuzzle02 : MonoBehaviour {

	public GameObject player;
    public GameObject cam_puzzle;
	public CinemachineVirtualCamera cam;
    public GameObject interativo;
    public GameObject puzzleA;
    public GameObject instrucao;

    public int puzzle02_B = 25;


	void Start () {
        interativo.GetComponent<move2>().enabled = false;

	}



     void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            instrucao.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player"))
        {
            instrucao.SetActive(false);
            player.GetComponent<CharController>().inPuzzle = true;
            player.SetActive(false);

			cam.Priority = 12;

            interativo.GetComponent<move2>().enabled = true;
            interativo.GetComponent<move2>().maxMov = puzzle02_B;
        }
    }

    void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);
    }
}

