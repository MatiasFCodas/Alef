using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucao01 : MonoBehaviour {

    public GameObject instrucao;
    public GameObject fundo;
    public GameObject hitBox;



    void OnTriggerEnter(Collider other)
    {


        instrucao.SetActive(true);
        fundo.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);
        fundo.SetActive(false);
        hitBox.SetActive(false);
    }
}





