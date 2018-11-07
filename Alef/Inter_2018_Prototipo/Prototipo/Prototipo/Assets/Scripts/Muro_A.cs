using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Muro_A : MonoBehaviour
{

    public GameObject player;
    public GameObject interativo01_A;
    public CinemachineVirtualCamera cam;

    public int moves = 5;

    // Use this for initialization
    void Start()
    {
        interativo01_A.GetComponent<move2>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
 

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<CharController>().inPuzzle = true;
            //   cam_puzzle01A.SetActive(true);
            cam.Priority = 12;
            interativo01_A.GetComponent<move2>().enabled = true;
            interativo01_A.GetComponent<move2>().maxMov = moves;
        }
    }

}
