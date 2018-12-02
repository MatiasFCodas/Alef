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
    //public GameObject puzzleDisco;

    public CinemachineVirtualCamera cam;

    public int MaxMov;

    public GameObject fim;

    public GameObject fimOutrosPuzzles_01;
    public GameObject fimOutrosPuzzles_02;
    public GameObject instrucao;
    public GameObject instrucaoGeral;


    void Start()
    {
        Cubo.GetComponent<move2>().enabled = false;
        fim.GetComponent<F2_Fim>().enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instrucao.SetActive(true);
            instrucaoGeral.SetActive(false);
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {

            instrucao.SetActive(false);

            Cubo.GetComponent<move2>().left = true;
            Cubo.GetComponent<move2>().up = true;
            Cubo.GetComponent<move2>().right = true;
            Cubo.GetComponent<move2>().down = true;

            fimOutrosPuzzles_01.SetActive(false);
            fimOutrosPuzzles_02.SetActive(false);

            //puzzleDisco.SetActive(false);
            fim.GetComponent<F2_Fim>().enabled = true;
            player.GetComponent<CharController>().inPuzzle = true;
            cam.Priority = 12;
            Cubo.GetComponent<move2>().enabled = true;
            Cubo.GetComponent<move2>().maxMov = MaxMov;
        }
    }

     void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);

    }
}
