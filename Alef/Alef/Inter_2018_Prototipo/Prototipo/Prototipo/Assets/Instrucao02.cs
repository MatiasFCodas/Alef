using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucao02 : MonoBehaviour {

    public GameObject instrucao;
    public GameObject fundo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instrucao.SetActive(false);
            fundo.SetActive(false);
        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instrucao.SetActive(true);
            fundo.SetActive(true);
        }


    }
    private void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);
        fundo.SetActive(false);
    }


}
