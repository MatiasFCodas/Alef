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
    public GameObject instrucao;


    void Start()
    {
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
            player.GetComponent<CharController>().inPuzzle = true;
            player.SetActive(false);
            instrucao.SetActive(false);


            cam.Priority = 12;

            interativo.GetComponent<move2>().enabled = true;
            interativo.GetComponent<move2>().maxMov = puzzle02_C;
        }
    }

    void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);
    }
}
