using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class F2_Inicio : MonoBehaviour {


    /// <Explicação>
    /// 
    /// Script aonde o puzzle de cubo
    /// da fase 2 é ativado para ser
    /// realizado. 
    /// 
    /// Além disso aqui também é aonde 
    /// se decide o número maximo de
    /// vezes que o cubo irá se mover
    /// 
    /// </Explicação>

    public GameObject player;
    public GameObject Cubo;

    public CinemachineVirtualCamera cam;

    public int MaxMov;

    void Start()
    {
        Cubo.GetComponent<move2>().enabled = false;
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {

            player.GetComponent<CharController>().inPuzzle = true;
            cam.Priority = 12;
            Cubo.GetComponent<move2>().enabled = true;
            Cubo.GetComponent<move2>().maxMov = MaxMov;
        }
    }
}
