﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class F3_Inicio : MonoBehaviour {

    public GameObject player;
    public GameObject puzzlePetalas;

    public CinemachineVirtualCamera cam;



    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<CharController>().inPuzzle = true;
            cam.Priority = 12;
            puzzlePetalas.GetComponent<Movimento_Petalas_Lerp>().enabled = true;
        }
    }
}
