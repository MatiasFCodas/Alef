using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class F3_Inicio : MonoBehaviour {

    public GameObject player;
    public GameObject puzzlePetalas;
    public GameObject puzzleTotem;

    public CinemachineVirtualCamera cam;

    public ParticleSystem brilho_01;

    public GameObject instrucaoStart;
    public GameObject instrucao;

    void OnTriggerStay(Collider other)
    {
        instrucao.SetActive(false);
        instrucaoStart.SetActive(true);
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            instrucaoStart.SetActive(false);
            brilho_01.Play();
            player.GetComponent<CharController>().inPuzzle = true;
            cam.Priority = 12;
            puzzlePetalas.GetComponent<Movimento_Petalas_Lerp>().enabled = true;
            puzzleTotem.GetComponent<Totem_Manager>().enabled = true;
        }
    }
}
