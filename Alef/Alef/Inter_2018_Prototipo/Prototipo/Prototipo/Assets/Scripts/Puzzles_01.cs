using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Puzzles_01 : MonoBehaviour {

    public GameObject player;
    public GameObject interativo01_A;

    public GameObject cam_puzzle01A;
	public CinemachineVirtualCamera cam1;

    public int puzzle01_A = 17;




    // Use this for initialization
    void Start () {
        interativo01_A.GetComponent<move2>().enabled = false;


	}
	

     void OnTriggerStay(Collider other)
    {
        if ( Input.GetKeyDown(KeyCode.E))
        {


            player.GetComponent<CharController>().inPuzzle = true;
            player.SetActive(false);

		    cam1.Priority = 12;

            interativo01_A.GetComponent<move2>().enabled = true;
            interativo01_A.GetComponent<move2>().maxMov = puzzle01_A;

        }
        }
    }

