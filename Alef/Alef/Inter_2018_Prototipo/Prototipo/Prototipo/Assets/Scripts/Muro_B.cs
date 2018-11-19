using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Muro_B : MonoBehaviour {

    public GameObject player;
    public GameObject interativo01_B;
    public GameObject instrucoes02;
    public CinemachineVirtualCamera cam;

    public int moves = 100;

    // Use this for initialization
    void Start () {
        interativo01_B.GetComponent<move2>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            instrucoes02.SetActive(true);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player"))
        {
            instrucoes02.SetActive(false);
            player.GetComponent<CharController>().inPuzzle = true;
        //    cam_puzzle01B.SetActive(true);
			cam.Priority = 12;
            interativo01_B.GetComponent<move2>().enabled = true;
            interativo01_B.GetComponent<move2>().maxMov = moves;

        }


    }

}
