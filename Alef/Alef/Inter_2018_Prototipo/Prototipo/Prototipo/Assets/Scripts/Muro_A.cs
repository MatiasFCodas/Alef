using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Muro_A : MonoBehaviour
{

    public GameObject player;
    public GameObject interativo01_A;
    public Instrucao01 instrucao;
    public GameObject instrucoes02;
    public GameObject instrucoes03;

    public CinemachineVirtualCamera cam;
  //  public GameObject brilhinhoFinal;

    public int moves = 5;

    // Use this for initialization
    void Start()
    {
        interativo01_A.GetComponent<move2>().enabled = false;
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
            instrucoes03.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = true;
            //   cam_puzzle01A.SetActive(true);
            cam.Priority = 12;
            interativo01_A.GetComponent<move2>().enabled = true;
            interativo01_A.GetComponent<move2>().maxMov = moves;
            // brilhinhoFinal.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        instrucoes02.SetActive(false);
    }

}
