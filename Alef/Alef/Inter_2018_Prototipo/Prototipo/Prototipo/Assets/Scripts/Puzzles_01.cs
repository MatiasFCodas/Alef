using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Puzzles_01 : MonoBehaviour {

    public GameObject player;

    public GameObject interativo01_A;
    public GameObject interativo01_B;
    public GameObject interativo01_C;

    public GameObject cam_puzzle01A;
	public CinemachineVirtualCamera cam1;
    public GameObject cam_puzzle01B;
	public CinemachineVirtualCamera cam2;
    public GameObject cam_puzzle01C;
	public CinemachineVirtualCamera cam3;

    public int puzzle01_A = 17;




    // Use this for initialization
    void Start () {
        interativo01_A.GetComponent<move2>().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {

            player.GetComponent<CharController>().inPuzzle = true;

            if (gameObject.tag == "Puzzle01_A")
            {
               
              //  cam_puzzle01A.SetActive(true);
				cam1.Priority = 12;
                interativo01_A.GetComponent<move2>().enabled = true;
                interativo01_A.GetComponent<move2>().maxMov = puzzle01_A;
            }
        }
    }
}
